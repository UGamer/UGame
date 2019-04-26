using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;

namespace The_UGamer_Launcher
{
    public partial class Settings : Form
    {
        public bool refresh = false;
        Form frm1;
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";
        private OleDbConnection con = new OleDbConnection(connectionString);
        public Settings(Form1 parent)
        {
            InitializeComponent();
            frm1 = parent;

            NotesButton.Click += DirectoryBrowse_Click;
            PagesButton.Click += DirectoryBrowse_Click;
            ResourcesButton.Click += DirectoryBrowse_Click;
            ScreenshotButton.Click += DirectoryBrowse_Click;
            UserDataButton.Click += DirectoryBrowse_Click;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'collectionDataSet5.Themes' table. You can move, or remove it, as needed.
            this.themesTableAdapter.Fill(this.collectionDataSet5.Themes);
            try
            {
                this.BackgroundImage = ThemeAssign("backgroundImageUSING");
            }
            catch (FileNotFoundException f) { }

            string[] themeFolders = Directory.GetDirectories(@"Resources\Theme\Presets\");
            string[] themeNames = new string[themeFolders.Length];

            int presetsIndex = themeFolders[0].IndexOf(@"Presets\");
            
            for (int index = 0; index < themeFolders.Length; index++)
            {
                themeNames[index] = themeFolders[index].Substring(presetsIndex + 8);
            }

            themeSelect.DataSource = themeNames;
        }

        private void saveApply_Click(object sender, EventArgs e)
        {
            Image newBG;
            Image newLogo;
            Icon newIcon;
            string filePath1 = "Resources/Theme/backgroundImage.png";
            string filePath2 = "Resources/Theme/logo.png";

            string themePath = themeSelect.Text;
            if (themePath == "") { }
            else
            {
                newBG = ThemeAssign("Presets/" + themePath + "/backgroundImage");
                newLogo = ThemeAssign("Presets/" + themePath + "/logo");
                newIcon = IconAssign("Presets/" + themePath + "/icon");

                /*
                var savedBG = new Bitmap(newBG);
                var savedLogo = new Bitmap(newLogo);
                
                savedBG.Save(filePath1, ImageFormat.Png);
                savedLogo.Save(filePath2, ImageFormat.Png);
                */
                
                if (newBG.RawFormat == ImageFormat.Gif)
                this.Text = ".GIF";

                // File.Copy();

                // refresh = true;
                NoChangesLabel.Visible = false;
            }

            if (refresh == true)
            {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                NoChangesLabel.Visible = true;
            }
        }

        public Image ThemeAssign(string input2)
        {
            Image background;
            try
            {
                background = Image.FromFile("Resources/Theme/" + input2 + ".png");
                return background;
            }
            catch (FileNotFoundException e)
            {
                try
                {
                    background = Image.FromFile("Resources/Theme/" + input2 + ".jpg");
                    return background;
                }
                catch (FileNotFoundException f)
                {
                    try
                    {
                        background = Image.FromFile("Resources/Theme/" + input2 + ".jpeg");
                        return background;
                    }
                    catch (FileNotFoundException g)
                    {
                        try
                        {
                            background = Image.FromFile("Resources/Theme/" + input2 + ".gif");
                            return background;
                        }
                        catch (FileNotFoundException h)
                        {
                            return background = Image.FromFile("Resources/DONT TOUCH.png");
                        }
                    }
                }
            }
        }

        public Icon IconAssign(string input2)
        {
            Icon windowIcon;
            try
            {
                windowIcon = new Icon("Resources/Theme/" + input2 + ".ico");
                return windowIcon;
            }
            catch (FileNotFoundException e)
            {
                windowIcon = new Icon("Resources/Theme/icon.ico");
                return windowIcon;
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (refresh == true)
            {
                Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
        }

        private void ColumnAddButton_Click(object sender, EventArgs e)
        {
            string table = ColumnTableBox.Text;
            string name = ColumnNameBox.Text;
            string type = ColumnTypeBox.Text;
            ColumnAdd(name, type, table);
        }

        private void ColumnAdd(string name2, string type2, string table2)
        {
            name2.Trim();
            type2.Trim();
            table2.Trim();

            if (table2 == "Games")
            {
                table2 = "Table1";
            }
            
            OleDbCommand cmd = new OleDbCommand("ALTER TABLE " + table2 + " ADD " + name2 + " " + type2 + ";", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        
        private void DirectoryBrowse_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            string boxName = tempButton.Tag.ToString();
            string path = "";

            DialogResult result = FolderBrowseDialog.ShowDialog();
            if (result == DialogResult.OK) // Test result.
                path = FolderBrowseDialog.SelectedPath;

            if (boxName == "Notes")
                NotesBox.Text = path;
            else if (boxName == "Pages")
                PagesBox.Text = path;
            else if (boxName == "Resources")
                ResourcesBox.Text = path;
            else if (boxName == "Screenshots")
                ScreenshotBox.Text = path;
            else if (boxName == "User Data")
                UserDataBox.Text = path;

            refresh = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (refresh == true)
            {

            }
        }
    }
}
