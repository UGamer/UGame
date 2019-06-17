using IGDB;
using IGDB.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame_Database_Convert__OLD_TO_NEW_
{
    public partial class DGVForm : Form
    {
        string type;
        public string data;
        Review refer;

        DataTable dataTable;
        ArrayList titles;
        ArrayList secondColumn;

        string[] currentImage = { "bg", "details", "icons" };
        int imageTypeIndex = 0;
        WebClient webClient = new WebClient();

        public DGVForm(string type, string data, Review refer)
        {
            this.DialogResult = DialogResult.Cancel;

            this.type = type;
            this.data = data;
            this.refer = refer;

            InitializeComponent();

            if (type == "DB" || type == "Images")
                FillDGV(true);
            else
                FillDGV();
        }

        private void FillDGV(bool placeholder)
        {
            dataTable = new DataTable();

            if (type == "DB")
            {
                dataTable.Columns.Add("Title");
                dataTable.Columns.Add("Platform");
                dataTable.Columns.Add("Developers");
                dataTable.Columns.Add("Publishers");
                dataTable.Columns.Add("Release Date");
                dataTable.Columns.Add("Genre");
                dataTable.Columns.Add("Description");

                SearchDatabase();
            }
            else if(type == "Images")
            {
                this.Text = "Image Selector";
                MessageBox.Show("Please pick an image to use.");

                dataTable.Columns.Add(); // url
                dataTable.Columns.Add("", typeof(Image)); // image
                dataTable.Columns.Add();
                /*
                dataTable.Columns.Add("", typeof(Image));
                dataTable.Columns.Add();
                dataTable.Columns.Add("", typeof(Image));
                */

                ImageDatabase();
            }
            else if (type == "ImagesChoice")
            {
            Console.WriteLine(refer.TitleBox.Text);
                dataTable.Columns.Add("Title");
                TitleDatabase();

                this.Text = "Title Selector";
                MessageBox.Show("Please pick a title to use.");
            }
        }

        private async void ImageDatabase()
        {
            DGVForm imageChoice = new DGVForm("ImagesChoice", "", refer);
            DialogResult dialogResult = imageChoice.ShowDialog();

            string title = "";
            if (dialogResult == DialogResult.Yes)
            {
                title = imageChoice.data;
            }

            var igdb = IGDB.Client.Create("6588e966357049df69fa0ec8bd422e92");
            var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "fields name,artworks.image_id; where name = " + title + ";");
            var artworkImageId = games.First().Artworks.Values.First().ImageId;
            
            // Thumbnail
            var thumb = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.Thumb, retina: false);
            var thumb2X = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.Thumb, retina: true);

            // Covers
            var coverSmall = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.CoverSmall, retina: false);

            var screenshotLarge = IGDB.ImageHelper.GetImageUrl(imageId: artworkImageId, size: ImageSize.ScreenshotBig, retina: false);

            string fileExt = coverSmall.Substring(screenshotLarge.IndexOf(".", screenshotLarge.Length - 5));
            
            string url = coverSmall;
            Image image;

            byte[] imageBytes = webClient.DownloadData("https:" + screenshotLarge);

            using (MemoryStream memstr = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(memstr);
            }

            int imgCount = 0;
            int row = 1;
            int col = 1;

            DataRow dRow = dataTable.NewRow();
            dataTable.Rows.Add();

            dRow[col - 1] = "https:" + screenshotLarge;
            dRow[col] = image;

            dataTable.Rows.Add(dRow);
            row++; col++;

            DGV.DataSource = dataTable;
        }

        private async void TitleDatabase()
        {
            var igdb = IGDB.Client.Create("6588e966357049df69fa0ec8bd422e92");
            var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "search \"" + refer.TitleBox.Text + "\";fields name;");

            DataRow dRow;
            for (int index = 0; index < games.Length; index++)
            {
                dRow = dataTable.NewRow();
                dRow[0] = games[index].Name;
                dataTable.Rows.Add(dRow);
            }

            DGV.DataSource = dataTable;
        }

        private async void SearchDatabase()
        {
            var igdb = IGDB.Client.Create("6588e966357049df69fa0ec8bd422e92");
            // var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "search \"" + data + "\"; fields name,release_dates.platform.name,involved_companies.developer,involved_companies.publisher,involved_companies.company.name,release_dates.human,genres,genres.name,summary;");
            var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "search \"" + data + "\"; fields *,release_dates.*,release_dates.platform.*,involved_companies.*,involved_companies.company.*,genres.*; limit 25;");
            
            DataRow dataRow;
            
            string platform = "";
            string developers = "";
            string publishers = "";
            string releaseDate = "";
            string genre = "";

            for (int index = 0; index < games.Length; index++)
            {
                dataRow = dataTable.NewRow();

                bool uniquePlatform = false;
                int platformCount;
                ArrayList platformsUsed = new ArrayList();
                platformsUsed.Add("Test");
                try { platformCount = games[index].ReleaseDates.Values.Count(); } catch { platformCount = 0; }
                for (int x = 0; x < platformCount; x++)
                {
                    for (int y = 0; y < platformsUsed.Count; y++)
                    {
                        if (platformsUsed[y].ToString() != games[index].ReleaseDates.Values[x].Platform.Value.Name)
                            uniquePlatform = true;
                        else
                        {
                            uniquePlatform = false;
                            break;
                        }
                            
                    }
                    if (uniquePlatform == true)
                    {
                        platformsUsed.Add(games[index].ReleaseDates.Values[x].Platform.Value.Name);
                        try { platform += games[index].ReleaseDates.Values[x].Platform.Value.Name; } catch { }
                        if (x + 1 < platformCount)
                            platform += ", ";
                    }
                    uniquePlatform = false;
                }
                platformsUsed.Remove("Test");
                if (platform.IndexOf(",", platform.Length - 2) != -1)
                    platform = platform.Substring(0, platform.Length - 2);

                int companiesCount;
                try { companiesCount = games[index].InvolvedCompanies.Values.Count(); } catch { companiesCount = 0; }
                for (int x = 0; x < companiesCount; x++)
                {
                    InvolvedCompany currentCompany = games[index].InvolvedCompanies.Values[x];

                    if (currentCompany.Developer == true)
                    {
                        if (developers == "")
                            try { developers = games[index].InvolvedCompanies.Values[x].Company.Value.Name; } catch { }
                        else
                            try { developers += ", " + games[index].InvolvedCompanies.Values[x].Company.Value.Name; } catch { }
                    }


                    if (currentCompany.Publisher == true)
                    {
                        if (publishers == "")
                            try { publishers = games[index].InvolvedCompanies.Values[x].Company.Value.Name; } catch { }
                        else
                            try { publishers += ", " + games[index].InvolvedCompanies.Values[x].Company.Value.Name; } catch { }
                    }
                }
                
                int year = 1753;
                int month = 1;
                int day = 1;

                int releaseCount;
                ArrayList releases = new ArrayList();
                ArrayList platforms = new ArrayList();
                try { releaseCount = games[index].ReleaseDates.Values.Count(); } catch { releaseCount = games.Count(); }
                
                /*
                for (int x = 0; x < releaseCount; x++)
                {
                    try { releases.Add(games[index].ReleaseDates.Values[x].Human); } catch { }
                    try { platforms.Add(games[index].ReleaseDates.Values[x].Platform.Value.Name); } catch { }
                }

                int i = 0;
                bool unique = true;
                ArrayList uniqueDates = new ArrayList();
                for (int x = 0; x < releases.Count; x++)
                {
                    for (int y = 0; y < uniqueDates.Count; y++)
                    {
                        i++;
                        if (releases[x] == uniqueDates[y])
                        {
                            unique = false;
                        }
                    }
                    if (unique == true)
                    {
                        uniqueDates.Add(releases[x] + "[" + i + "]");
                        i = 0;
                    }

                    unique = true;
                }
            
                if (uniqueDates.Count == 1)
                {
                    try { year = Convert.ToInt32(uniqueDates.ToString().Substring(0, 4)); } catch { }

                    string monthString = "Jan";
                    try { monthString = uniqueDates.ToString().Substring(5, 3); } catch { }

                    switch (monthString)
                    {
                        case "Jan":
                            month = 1;
                            break;
                        case "Feb":
                            month = 2;
                            break;
                        case "Mar":
                            month = 3;
                            break;
                        case "Apr":
                            month = 4;
                            break;
                        case "May":
                            month = 5;
                            break;
                        case "Jun":
                            month = 6;
                            break;
                        case "Jul":
                            month = 7;
                            break;
                        case "Aug":
                            month = 8;
                            break;
                        case "Sep":
                            month = 9;
                            break;
                        case "Oct":
                            month = 10;
                            break;
                        case "Nov":
                            month = 11;
                            break;
                        case "Dec":
                            month = 12;
                            break;
                        default:
                            break;
                    }
                    try { day = Convert.ToInt32(uniqueDates.ToString().Substring(9, 2)); } catch { }

                    releaseDate = year + "/" + month + "/" + day;
                }
                else if (uniqueDates.Count == 0)
                {
                    releaseDate = "1753/1/1";
                }
                else
                {
                    int z = 0;
                    for (int x = 0; x < uniqueDates.Count; x++)
                    {
                        string date = uniqueDates[x].ToString().Substring(0, 10);
                        i = Convert.ToInt32(uniqueDates[x].ToString().Substring(12, 1));

                        releaseDate += date + " [";
                        for (int w = 0; w <= i; i++)
                        {
                            releaseDate += platforms[z];
                            if (w == i)
                                releaseDate += "]";
                            else
                                releaseDate += ", ";
                            z++;
                        }

                        if (x != uniqueDates.Count - 1)
                            releaseDate += ", ";
                    }
                }
                */

                try { year = Convert.ToInt32(games[index].ReleaseDates.Values[0].Human.Substring(0, 4)); } catch { }

                string monthString = "Jan";
                try { monthString = games[index].ReleaseDates.Values[0].Human.Substring(5, 3); } catch { }

                switch (monthString)
                {
                    case "Jan":
                        month = 1;
                        break;
                    case "Feb":
                        month = 2;
                        break;
                    case "Mar":
                        month = 3;
                        break;
                    case "Apr":
                        month = 4;
                        break;
                    case "May":
                        month = 5;
                        break;
                    case "Jun":
                        month = 6;
                        break;
                    case "Jul":
                        month = 7;
                        break;
                    case "Aug":
                        month = 8;
                        break;
                    case "Sep":
                        month = 9;
                        break;
                    case "Oct":
                        month = 10;
                        break;
                    case "Nov":
                        month = 11;
                        break;
                    case "Dec":
                        month = 12;
                        break;
                    default:
                        break;
                }
                try { day = Convert.ToInt32(games[index].ReleaseDates.Values[0].Human.Substring(9, 2)); } catch { }

                releaseDate = year + "/" + month + "/" + day;

                int genreCount;
                try { genreCount = games[index].Genres.Values.Count(); } catch { genreCount = 0; }
                for (int x = 0; x < genreCount; x++)
                {
                    genre += games[index].Genres.Values[x].Name;
                    if (x + 1 < genreCount)
                        genre += ", ";
                }

                dataRow["Title"] = games[index].Name;
                dataRow["Platform"] = platform;
                dataRow["Developers"] = developers;
                dataRow["Publishers"] = publishers;
                dataRow["Release Date"] = releaseDate;
                dataRow["Genre"] = genre;
                dataRow["Description"] = games[index].Summary;

                dataTable.Rows.Add(dataRow);
                
                platform = "";
                developers = "";
                publishers = "";
                releaseDate = "";
                genre = "";
            }

            DGV.DataSource = dataTable;

            DGV.ReadOnly = true;

            DGV.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Platform"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Developers"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Publishers"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Release Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGV.Columns["Genre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            // DGV.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void FillDGV()
        {
            dataTable = new DataTable();
            titles = new ArrayList();
            secondColumn = new ArrayList();

            dataTable.Columns.Add("Title");

            if (type == "URLs")
            {
                dataTable.Columns.Add("URL");
            }
            else if (type == "Launch")
            {
                dataTable.Columns.Add("Code");
            }

            DataRow dataRow;
            string section = data;
            string title;
            string url;
            string pattern1 = "[Title]";
            string pattern2 = "[URL]";
            int index = 0;
            while (section.IndexOf(pattern1) != -1) // get rid of arraylist and just add straight to datatable
            {
                section = section.Substring(pattern1.Length);
                title = section.Substring(0, section.IndexOf(pattern2));
                titles.Add(title);

                section = section.Substring(section.IndexOf(pattern2) + pattern2.Length);
                try { url = section.Substring(0, section.IndexOf(pattern1)); } catch { url = section; }
                secondColumn.Add(url);

                try { section = section.Substring(section.IndexOf(pattern1)); } catch { }

                dataRow = dataTable.NewRow();
                dataRow[0] = titles[index];
                dataRow[1] = secondColumn[index];
                dataTable.Rows.Add(dataRow);

                index++;
            }

            DGV.DataSource = dataTable;
        }

        private void DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (type == "DB")
                {
                    refer.TitleBox.Text = DGV.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    refer.PlatformBox.Text = DGV.Rows[e.RowIndex].Cells["Platform"].Value.ToString();
                    refer.DevelopersBox.Text = DGV.Rows[e.RowIndex].Cells["Developers"].Value.ToString();
                    refer.PublishersBox.Text = DGV.Rows[e.RowIndex].Cells["Publishers"].Value.ToString();
                    
                    if (DGV.Rows[e.RowIndex].Cells["Release Date"].Value.ToString() == "1/1/1753")
                    {
                        refer.ReleaseDatePicker.Value = DateTime.Now;
                        refer.ReleaseDateCheck.Checked = true;
                    }
                    else
                    {
                        refer.ReleaseDatePicker.Value = Convert.ToDateTime(DGV.Rows[e.RowIndex].Cells["Release Date"].Value);
                        refer.ReleaseDateCheck.Checked = false;
                    }

                    refer.GenreBox.Text = DGV.Rows[e.RowIndex].Cells["Genre"].Value.ToString();
                    refer.GameDescBox.Text = DGV.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                }
                else if (type.IndexOf("Images") != -1)
                {
                    string remoteFileUrl = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string fileExt = remoteFileUrl;

                    while (fileExt.IndexOf(".") != -1)
                        fileExt = fileExt.Substring(fileExt.IndexOf(".") + 1);

                    string localFileName = "resources\\" + currentImage[imageTypeIndex] + "\\" + refer.TitleBox.Text + "." + fileExt;

                    webClient.DownloadFile(remoteFileUrl, localFileName);
                    byte[] imageBytes = webClient.DownloadData("https:" + remoteFileUrl);
                    File.WriteAllBytes("temp\\0.jpg", imageBytes);

                    this.Close();
                }
                else if (type.IndexOf("ImagesChoice") != -1)
                {
                    this.DialogResult = DialogResult.Yes;
                    data = DGV.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                    this.Close();
                }
            }
            catch { }
        }

        private void DGVForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string returnString = "";

            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                returnString += "[Title]" + dataTable.Rows[index][0] + "[URL]" + dataTable.Rows[index][1];
            }

            if (type == "Launch")
                refer.launchString = returnString;
            else if (type == "URLs")
                refer.urlString = returnString;
        }
    }
}
