using System;
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

namespace UGame
{
    public partial class TaskCreate : Form
    {
        string friendlyTitle;
        Tasks refer;

        public TaskCreate(string friendlyTitle, Tasks refer)
        {
            this.friendlyTitle = friendlyTitle;
            this.refer = refer;

            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory("Tasks\\" + friendlyTitle + "\\" + TaskBox.Text);

            File.Create("Tasks\\" + friendlyTitle + "\\" + TaskBox.Text + "\\text.txt");

            Image img = ImageBox.BackgroundImage;
            try { img.Save("Tasks\\" + friendlyTitle + "\\" + TaskBox.Text + "\\img.png"); } catch { }

            refer.FillGrid();
            this.Close();
        }

        private void ImageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.PictureContextMenu.Show(this.ImageBox, e.Location);
                PictureContextMenu.Show(Cursor.Position);
            }
        }

        private void ClearPictureButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("HEADS UP: Clearing a file will not delete it.", "Clearing Picture", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.OK)
            {
                ImageBox.BackgroundImage = null;
            }
        }

        private void LocalPictureButton_Click(object sender, EventArgs e)
        {
            if (PictureDialog.ShowDialog() == DialogResult.OK)
            {
                ImageBox.BackgroundImage = Image.FromFile(PictureDialog.FileName);
            }
        }

        private void InternetPictureButton_Click(object sender, EventArgs e)
        {
            Browser browser = new Browser("https://www.google.com", "Download");
            DialogResult dialogResult = browser.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                string downloadUrl = browser.downloadUrl;

                WebClient webClient = new WebClient();
                try
                {
                    byte[] imageBytes = webClient.DownloadData(downloadUrl);
                    Console.WriteLine(imageBytes.LongLength);

                    using (var ms = new MemoryStream(imageBytes))
                    {
                        ImageBox.BackgroundImage = Image.FromStream(ms);
                    }
                }
                catch
                {
                    MessageBox.Show("Image download failed.");
                }
            }
        }
    }
}
