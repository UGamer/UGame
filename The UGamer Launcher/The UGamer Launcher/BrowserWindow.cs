using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections;
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
        string title;
        ToolStripButton[] linkButton;
        private string currentURL;
        ChromiumWebBrowser Browser;
        GameDetails details;

        public BrowserWindow(string[,] links, int linkCount, string title)
        {
            InitializeComponent();
            LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");

            this.links = links;
            this.linkCount = linkCount;
            this.title = title;
            InitializeBrowser();
            InitializeLinks();
            InitializeDesign();
        }

        public BrowserWindow(string[,] links, int linkCount, string title, GameDetails detailsWindow)
        {
            InitializeComponent();
            this.links = links;
            this.linkCount = linkCount;
            this.title = title;
            this.details = detailsWindow;
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
            Browser.Parent = tabControl1.SelectedTab;
            Browser.Dock = DockStyle.Fill;
            Browser.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top);
            this.TabPage1.Controls.Add(Browser);
            Browser.AddressChanged += Browser_AddressChanged;
            Browser.TitleChanged += Browser_TitleChanged;
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

            for (int index = 0; index < linkCount; index++)
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
            string linkTitle = sender.ToString();
            ToolStripButton tempButton = (ToolStripButton)sender;
            for (int index = 0; index < linkCount; index++)
                if (links[0, index] == linkTitle)
                {
                    ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load(links[1, index]);
                }
                else if (tempButton.Tag.ToString() != "")
                {
                    ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load(tempButton.Tag.ToString());
                }
        }

        private void Search()
        {
            currentURL = AddressBox.Text;
            if (currentURL.IndexOf(" ") == -1)
            {
                if (currentURL.IndexOf(".co") == -1)
                {
                    ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load("https://www.google.com/search?q=" + currentURL);
                }
                else
                {
                    ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load(currentURL);
                }
                
            }
            else
            {
                ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                chrome.Load("https://www.google.com/search?q=" + currentURL);
            }
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
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome.CanGoBack)
            {
                chrome.Back();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            chrome.Refresh();
        }

        private void BrowserWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Browser.Dispose();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;

            if (chrome.CanGoForward)
            {
                chrome.Forward();
            }
        }

        private void NewTabButton_Click(object sender, EventArgs e)
        {
            creationCheck = true;
            TabPage newPage = new TabPage();
            newPage.Text = "New Tab";
            tabControl1.Controls.Add(newPage);
            tabControl1.SelectTab(tabControl1.TabCount - 1);

            ChromiumWebBrowser chrome = new ChromiumWebBrowser("www.google.com");
            chrome.Parent = newPage;
            chrome.Dock = DockStyle.Fill;
            AddressBox.Text = "www.google.com";
            chrome.AddressChanged += Browser_AddressChanged;
            chrome.TitleChanged += Browser_TitleChanged;
            creationCheck = false;
        }

        private void Browser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tabControl1.SelectedTab.Text = e.Title;
            }));
        }

        bool creationCheck = false;

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (creationCheck == false)
            {
                ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
                AddressBox.Text = chrome.Address;
            }
            creationCheck = false;
        }

        ArrayList addedLinks = new ArrayList();
        ArrayList addedLinkNames = new ArrayList();

        private void FavoriteButton_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome = tabControl1.SelectedTab.Controls[0] as ChromiumWebBrowser;
            AddLinks newLink = new AddLinks(chrome.Address, title, tabControl1.SelectedTab.Text);
            newLink.Show();
            newLink.FormClosed += newLink_FormClosed;
            this.newLink = newLink;
        }

        AddLinks newLink;

        private void newLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            ToolStripButton newLinkButton = new ToolStripButton();
            newLinkButton.Text = newLink.linkTitle;
            newLinkButton.Tag = newLink.linkURL;
            newLinkButton.Click += linkButton_Click;
            LinksBar.Items.Add(newLinkButton);

            details.allLinks += newLink.newsString;
        }

        public bool locked = false;

        private void LockButton_Click(object sender, EventArgs e)
        {
            if (locked == false)
            {
                locked = true;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Lock.png");
            }
            else
            {
                locked = false;
                LockButton.BackgroundImage = Image.FromFile("Resources\\Theme\\Unlock.png");
            }
        }

        private void OpacityBar_ValueChanged(object sender, EventArgs e)
        {
            double opacityValue = Convert.ToDouble(OpacityBar.Value);
            opacityValue /= 100;
            this.Opacity = opacityValue;
        }
    }
}