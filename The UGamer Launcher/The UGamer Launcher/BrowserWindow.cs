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
        }
        

        private void InitializeBrowser()
        {
            try
            {
                Browser = new ChromiumWebBrowser(links[1, 0]);
                AddressBox.Text = links[1, 0];
            }
            catch (IndexOutOfRangeException e)
            {
                Browser = new ChromiumWebBrowser("google.com");
                AddressBox.Text = "https://www.google.com";
            }
            
            // Add it to the form and fill it to the form window.
            Size browserSize = new Size(801, 389);
            Browser.Size = browserSize;
            Browser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.BrowserDock.Controls.Add(Browser);
            Browser.AddressChanged += Browser_AddressChanged;
        }

        void Browser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                AddressBox.Text = e.Address;
            }));
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
                linkButton[index].Click += linkButton_Click;
            }
        }

        private void InitializeDesign()
        {

        }

        private void linkButton_Click(object sender, EventArgs e)
        {
            /*
            string linkTitle = sender.ToString();
            for (int index = 0; index < links.Length; index++)
                if (links[0, index] == linkTitle)
                    Browser.Load(links[1, index]);
            */
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

        private void AddressBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.Back();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void BrowserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.Forward();
            }
        }
    }
}
