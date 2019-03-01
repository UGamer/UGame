using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace The_UGamer_Launcher
{
    public partial class BrowserWindow : Form
    {
        public static bool flag = true;
        globalKeyboardHook gkh = new globalKeyboardHook();

        private string[,] links;
        private int linkCount;
        ToolStripButton[] linkButton;

        private string currentURL;
        ChromiumWebBrowser Browser;

        public BrowserWindow(string[,] links, int linkCount)
        {
            InitializeComponent();

            this.links = links;
            this.linkCount = linkCount;

            InitializeBrowser();
            InitializeLinks();
            InitializeDesign();

            /*
            gkh.HookedKeys.Add(Keys.Home);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);
            */
        }

        private void InitializeBrowser()
        {
            Browser = new ChromiumWebBrowser(links[1, 0]);
            // Add it to the form and fill it to the form window.
            Size browserSize = new Size(801, 389);
            Browser.Size = browserSize;
            Browser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.BrowserDock.Controls.Add(Browser);
        }

        private void InitializeLinks()
        {
            linkButton = new ToolStripButton[linkCount];

            for (int index = 0; index < linkButton.Length; index++)
            {
                linkButton[index] = new ToolStripButton();
                linkButton[index].DisplayStyle = ToolStripItemDisplayStyle.Text;
                linkButton[index].Text = links[0, index];
                LinksBar.Items.Add(linkButton[index]);
            }
        }

        private void InitializeDesign()
        {

        }

        private void Search()
        {
            currentURL = AddressBox.Text;
            Browser.Load(currentURL);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                if (flag)
                {
                    this.Hide();
                    flag = false;
                }
                else
                {
                    this.Show();
                    flag = true;
                }

                e.Handled = true;
            }
        }

        private void BrowserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            gkh.unhook();
        }
    }
}
