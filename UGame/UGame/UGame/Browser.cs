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

namespace UGame
{
    public partial class Browser : Form
    {
        public string type;
        public bool open;

        string[,] links;
        private int linkCount;
        
        ToolStripButton[] linkButton;
        public ChromiumWebBrowser chromeBrowser;
        MenuHandler menuHandler;
        public string url;
        public string downloadUrl;
        public bool locked = false;

        bool creationCheck = false;

        public Browser(string url, string type)
        {
            this.url = url;
            this.type = type;
            open = true;

            InitializeComponent();

            if (url.IndexOf("[Title]") != -1)
            {
                InitializeLinks();
            }

            if (type == "Browser")
            {
                DownloadButton.Visible = false;
                AddressBar.Size = new Size(668, 20);
            }

            InitializeChromium();
        }

        public void InitializeChromium()
        {
            try { chromeBrowser = new ChromiumWebBrowser(links[0,1]); }
            catch {
                try { chromeBrowser = new ChromiumWebBrowser(url); }
                catch { chromeBrowser = new ChromiumWebBrowser("https://www.google.com"); }
            }

            tabPage1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += chromeBrowser_AddressChanged;
            chromeBrowser.TitleChanged += chromeBrowser_TitleChanged;
            menuHandler = new MenuHandler(this);
            chromeBrowser.MenuHandler = menuHandler;
        }
        
        private void InitializeLinks()
        {
            ToolStripButton linkButton;

            // IMPLEMENT DEFAULT LINKS HERE

            // IMPLEMENT DEFAULT LINKS HERE
            
            string segment = url;

            int linkCount = 0;
            while (segment.IndexOf("[Title]") != -1)
            {
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);
                linkCount++;
            }
            links = new string[linkCount, 2];
            
            segment = url;
            for (int index = 0; index < linkCount; index++)
            {
                segment = segment.Substring(segment.IndexOf("[Title]") + 7);
                links[index, 0] = segment.Substring(0, segment.IndexOf("[URL]"));

                segment = segment.Substring(segment.IndexOf("[URL]") + 5);
                try { links[index, 1] = segment.Substring(0, segment.IndexOf("[Title]")); }
                catch { links[index, 1] = segment; }

                linkButton = new ToolStripButton();
                linkButton.Click += LinkButton_Click;
                linkButton.Text = links[index, 0];
                linkButton.Tag = links[index, 1];

                BookmarkBar.Items.Add(linkButton);
            }
        }

        private void Search()
        {
            string currentURL = AddressBar.Text;
            if (currentURL.IndexOf(" ") == -1)
            {
                if (currentURL.IndexOf(".co") == -1)
                {
                    ChromiumWebBrowser chrome = Tabs.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load("https://www.google.com/search?q=" + currentURL);
                }
                else
                {
                    ChromiumWebBrowser chrome = Tabs.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    chrome.Load(currentURL);
                }

            }
            else
            {
                ChromiumWebBrowser chrome = Tabs.SelectedTab.Controls[0] as ChromiumWebBrowser;
                chrome.Load("https://www.google.com/search?q=" + currentURL);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Search();
            }
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {
            ToolStripButton tempButton = (ToolStripButton)sender;
            chromeBrowser.Load(tempButton.Tag.ToString());
        }

        public void Download()
        {
            this.DialogResult = DialogResult.Yes;

            if (downloadUrl == "")
                url = chromeBrowser.Address;
            else
                url = downloadUrl;

            CrossThreadClose();
        }

        delegate void CallbackDownload();

        private void CrossThreadClose()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                CallbackDownload d = new CallbackDownload(CrossThreadClose);
                try { this.Invoke(d, new object[] { this }); } catch { }
            }
            else
            {
                this.Close();
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            downloadUrl = chromeBrowser.Address;
            Download();
        }

        private void chromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    AddressBar.Text = e.Address;
                }));
            }
            catch { }
        }

        private void chromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            try
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    Tabs.SelectedTab.Text = e.Title;
                }));
            }
            catch { }
        }

        public void NewTab()
        {
            creationCheck = true;
            try { Tabs.Controls.RemoveAt(Tabs.TabCount - 1); } catch { }

            TabPage newPage = new TabPage();
            newPage.Text = "New Tab";
            try
            {
                Tabs.TabPages.Add(newPage);
                Tabs.SelectTab(newPage);

                chromeBrowser = new ChromiumWebBrowser("www.google.com");
                chromeBrowser.Parent = newPage;
                chromeBrowser.Dock = DockStyle.Fill;
                AddressBar.Text = "www.google.com";
                chromeBrowser.AddressChanged += chromeBrowser_AddressChanged;
                chromeBrowser.TitleChanged += chromeBrowser_TitleChanged;

                TabPage newTabPage = new TabPage();
                newTabPage.Text = "+";
                Tabs.Controls.Add(newTabPage);
            }
            catch { CrossThreadNewTab(); }
        }

        delegate void CallbackNewTab();

        public void CrossThreadNewTab()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.InvokeRequired)
            {
                CallbackDownload d = new CallbackDownload(CrossThreadClose);
                try { this.Invoke(d, new object[] { this.Tabs }); } catch { }
            }
            else
            {
                TabPage newPage = new TabPage();
                newPage.Text = "New Tab";
                Tabs.TabPages.Add(newPage);
                Tabs.SelectTab(newPage);

                chromeBrowser = new ChromiumWebBrowser("www.google.com");
                chromeBrowser.Parent = newPage;
                chromeBrowser.Dock = DockStyle.Fill;
                AddressBar.Text = "www.google.com";
                chromeBrowser.AddressChanged += chromeBrowser_AddressChanged;
                chromeBrowser.TitleChanged += chromeBrowser_TitleChanged;

                TabPage newTabPage = new TabPage();
                newTabPage.Text = "+";
                Tabs.Controls.Add(newTabPage);
            }
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome;
            if (!creationCheck)
            {
                if (Tabs.SelectedTab == Tabs.TabPages[Tabs.TabCount - 1] && Tabs.SelectedTab.Text == "+")
                {
                    NewTab();
                }
            }
            creationCheck = false;

            try
            {
                chrome = Tabs.SelectedTab.Controls[0] as ChromiumWebBrowser;
                AddressBar.Text = chrome.Address;
            }
            catch { }
        }

        private void Tabs_Selected(object sender, TabControlEventArgs e)
        {
            if (creationCheck)
            {
                try
                {
                    chromeBrowser = Tabs.SelectedTab.Controls[0] as ChromiumWebBrowser;
                    AddressBar.Text = chromeBrowser.Address;
                } catch { }
            }
            creationCheck = false;
        }

        private void OpacitySlider_ValueChanged(object sender, EventArgs e)
        {
            double opacityValue = Convert.ToDouble(OpacitySlider.Value);
            opacityValue /= 100;
            this.Opacity = opacityValue;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
                chromeBrowser.Back();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
                chromeBrowser.Forward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload(true);
        }

        private void Tabs_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.TabContextMenu.Show(this.Tabs, e.Location);
                    TabContextMenu.Show(Cursor.Position);
                }
            }
            catch { }
        }

        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            Tabs.Controls.Remove(Tabs.SelectedTab);
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cef.Shutdown();
        }
    }
}
