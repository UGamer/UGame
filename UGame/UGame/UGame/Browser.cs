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

namespace UGame
{
    public partial class Browser : Form
    {
        public ChromiumWebBrowser chromeBrowser;
        public string url;

        public Browser(string url)
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser("https://www.google.com");
            // Add it to the form and fill it to the form window.
            BrowserDock.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += chromeBrowser_AddressChanged;
            chromeBrowser.MenuHandler = new MenuHandler();
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load(AddressBar.Text);
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
