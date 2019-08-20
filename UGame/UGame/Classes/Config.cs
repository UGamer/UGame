using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UGame
{
    public class Config
    {
        string settings;

        bool firstTime = false;

        public string resourcePath;
        public string databasePath;

        public Config()
        {
            //try
            {
                settings = File.ReadAllText("settings.txt", Encoding.UTF8);
            }
            //catch
            {
                /*
                Setup setup = new Setup();
                DialogResult dialogResult = setup.ShowDialog();
                if (dialogResult == DialogResult.Yes)
                {

                }
                */
            }

            // To easily get the index additional number, take the length of the word and then add 2.

            string firstTimeString = settings.Substring(settings.IndexOf("FirstTime=\"") + 11);
            this.firstTime = Convert.ToBoolean(firstTimeString.Substring(0, firstTimeString.IndexOf("\"")));

            if (!firstTime)
            {
                this.resourcePath = settings.Substring(settings.IndexOf("ResourcePath=\"") + 14);
                this.resourcePath = resourcePath.Substring(0, resourcePath.IndexOf("\""));

                this.databasePath = settings.Substring(settings.IndexOf("DatabasePath=\"") + 14);
                this.databasePath = databasePath.Substring(0, databasePath.IndexOf("\""));

                if (databasePath == "")
                {
                    Uri location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
                    databasePath = new FileInfo(location.AbsolutePath).Directory.FullName + "\\UGameDB.mdf";
                }
            }
            else
            {

            }
        }
    }
}
