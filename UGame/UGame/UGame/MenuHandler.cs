using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UGame
{
    internal class MenuHandler : IContextMenuHandler
    {
        private const int Copy = 26503;
        private const int Download = 26504;
        private const int Open = 26505;
        private const int OpenNewTab = 26506;
        Browser refer;

        public MenuHandler(Browser refer)
        {
            this.refer = refer;
        }

        void IContextMenuHandler.OnBeforeContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model)
        {
            //Add new custom menu items
            model.AddItem((CefMenuCommand)Open, "Open");
            model.AddItem((CefMenuCommand)OpenNewTab, "Open in a New Tab");
            model.AddItem((CefMenuCommand)Copy, "Copy Link Address");

            if (refer.type == "Download")
                model.AddItem((CefMenuCommand)Download, "Download Image");
        }

        bool IContextMenuHandler.OnContextMenuCommand(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, CefMenuCommand commandId, CefEventFlags eventFlags)
        {
            if ((int)commandId == Copy)
            {
                //using System.Windows.Forms;
                Clipboard.SetText(parameters.SourceUrl);
            }
            else if ((int)commandId == Download)
            {
                refer.downloadUrl = parameters.SourceUrl;
                refer.Download();
            }
            else if ((int)commandId == Open)
            {
                browserControl.Load(parameters.SourceUrl);
            }
            else if ((int)commandId == OpenNewTab)
            {
                refer.NewTab();
                refer.chromeBrowser.Load(parameters.SourceUrl);
            }
            return false;
        }

        void IContextMenuHandler.OnContextMenuDismissed(IWebBrowser browserControl, IBrowser browser, IFrame frame)
        {

        }

        bool IContextMenuHandler.RunContextMenu(IWebBrowser browserControl, IBrowser browser, IFrame frame, IContextMenuParams parameters, IMenuModel model, IRunContextMenuCallback callback)
        {
            return false;
        }
    }
}
