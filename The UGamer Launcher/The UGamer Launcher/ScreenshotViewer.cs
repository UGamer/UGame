using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace The_UGamer_Launcher
{
    public partial class ScreenshotViewer : Form
    {
        string titleFriendly;

        string[] files;
        Image currentImage;
        Panel[] picturePanel;
        PictureBox[] pictureBox;
        Label[] pictureLabel;

        int xPosPanel = 3;
        int yPosPanel = 0;
        int xPosBox = 3;
        int yPosBox = 3;
        int xPosLabel = 3;
        int yPosLabel = 84;
        Point location;

        public ScreenshotViewer(string titleFriendly)
        {
            this.titleFriendly = titleFriendly;
            InitializeComponent();
            InitializeImages();
            InitializeDesign();
        }

        private void InitializeImages()
        {
            NoScreenshotsLabel.Visible = false;

            if (!Directory.Exists("Screenshots\\" + titleFriendly))
                NoScreenshotsLabel.Visible = true;
            else
            {
                files = Directory.GetFiles("Screenshots\\" + titleFriendly);
                FocusedPictureBox.BackgroundImage = Image.FromFile(files[0]);

                picturePanel = new Panel[files.Length];
                pictureBox = new PictureBox[files.Length];
                pictureLabel = new Label[files.Length];

                for (int index = 0; index < files.Length; index++)
                {
                    location = new Point(xPosPanel, yPosPanel);
                    // picturePanel.Location = location;
                }
            }
        }

        private void InitializeDesign()
        {

        }
    }
}
