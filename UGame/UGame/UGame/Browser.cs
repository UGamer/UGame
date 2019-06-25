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
        public bool open;

        string[,] links;
        private int linkCount;
        
        ToolStripButton[] linkButton;
        public ChromiumWebBrowser chromeBrowser;
        public string url;
        public bool locked = false;

        bool creationCheck = false;

        public Browser(string url)
        {
            this.url = url;
            open = true;

            InitializeComponent();

            if (url.IndexOf("[Title]") != -1)
            {
                InitializeLinks();
            }
            else
            {
                url = "https://www.google.com";
            }

            InitializeChromium();
        }

        public void InitializeChromium()
        {
            try { chromeBrowser = new ChromiumWebBrowser(links[0,1]); } catch { chromeBrowser = new ChromiumWebBrowser("https://www.google.com"); }

            tabPage1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += chromeBrowser_AddressChanged;
            chromeBrowser.TitleChanged += chromeBrowser_TitleChanged;
            chromeBrowser.MenuHandler = new MenuHandler();
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

        private void LinkButton_Click(object sender, EventArgs e)
        {
            ToolStripButton tempButton = (ToolStripButton)sender;
            chromeBrowser.Load(tempButton.Tag.ToString());
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            url = chromeBrowser.Address;

            this.Close();
        }

        private void chromeBrowser_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                AddressBar.Text = e.Address;
            }));
        }

        private void chromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            

            this.Invoke(new MethodInvoker(() =>
            {
                Tabs.SelectedTab.Text = e.Title;
            }));
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChromiumWebBrowser chrome;
            if (!creationCheck)
            {
                if (Tabs.SelectedTab == Tabs.TabPages[Tabs.TabCount - 1] && Tabs.SelectedTab.Text == "+")
                {
                    creationCheck = true;
                    try { Tabs.Controls.RemoveAt(Tabs.TabCount - 1); } catch { }
                    
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(AddressBar.Text);
        }

        private void OpacitySlider_ValueChanged(object sender, EventArgs e)
        {
            double opacityValue = Convert.ToDouble(OpacitySlider.Value);
            opacityValue /= 100;
            this.Opacity = opacityValue;
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Cef.Shutdown();
        }
    }
}
