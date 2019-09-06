using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UGame.Models;
using SQLite;
using SQLitePCL;

namespace UGame.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();

            string path = @"/storage/emulated/0/Android/data/com.ugame.ugame/files/UGameDB.db";
            SQLiteConnection con = new SQLiteConnection(path);

            items = con.Query<Item> ("SELECT \"Id\" AS \"Id\", \"Title\" AS \"Title\", \"Platform\" AS \"Platform\", \"TimePlayed\" AS \"TimePlayed\", \"Seconds\" AS \"Seconds\", \"LastPlayed\" AS \"LastPlayed\" FROM Games ORDER BY Title");

            string imageTitle;
            string iconPath, detailPath;
            for (int index = 0; index < items.Count; index++)
            {
                imageTitle = items[index].Title;
                Regex rgxFix1 = new Regex("/");
                Regex rgxFix2 = new Regex(":");
                Regex rgxFix3 = new Regex(".*");
                Regex rgxFix4 = new Regex(".?");
                Regex rgxFix5 = new Regex("\"");
                Regex rgxFix6 = new Regex("<");
                Regex rgxFix7 = new Regex(">");
                Regex rgxFix8 = new Regex("|");
                Regex rgxFix9 = new Regex(@"T:\\");

                while (imageTitle.IndexOf("/") != -1)
                    imageTitle = rgxFix1.Replace(imageTitle, "");
                while (imageTitle.IndexOf(":") != -1)
                    imageTitle = rgxFix2.Replace(imageTitle, "");
                while (imageTitle.IndexOf("*") != -1)
                    imageTitle = rgxFix3.Replace(imageTitle, "");
                while (imageTitle.IndexOf("?") != -1)
                    imageTitle = rgxFix4.Replace(imageTitle, "");
                while (imageTitle.IndexOf("\"") != -1)
                    imageTitle = rgxFix5.Replace(imageTitle, "");
                while (imageTitle.IndexOf("<") != -1)
                    imageTitle = rgxFix6.Replace(imageTitle, "");
                while (imageTitle.IndexOf(">") != -1)
                    imageTitle = rgxFix7.Replace(imageTitle, "");
                while (imageTitle.IndexOf("|") != -1)
                    imageTitle = rgxFix8.Replace(imageTitle, "");
                while (imageTitle.IndexOf("\\") != -1)
                    imageTitle = rgxFix9.Replace(imageTitle, "");

                iconPath = "/storage/emulated/0/Android/data/com.ugame.ugame/files/resources/icons/";

                if (File.Exists(iconPath + imageTitle + ".png"))
                    items[index].IconPath = iconPath + imageTitle + ".png";
                if (File.Exists(iconPath + imageTitle + ".jpg"))
                    items[index].IconPath = iconPath + imageTitle + ".jpg";
                if (File.Exists(iconPath + imageTitle + ".jpeg"))
                    items[index].IconPath = iconPath + imageTitle + ".jpeg";
                if (File.Exists(iconPath + imageTitle + ".gif"))
                    items[index].IconPath = iconPath + imageTitle + ".gif";

                if (items[index].IconPath == null)
                    items[index].IconPath = "/storage/emulated/0/Android/data/com.ugame.ugame/files/resources/unknown.png";


                detailPath = "/storage/emulated/0/Android/data/com.ugame.ugame/files/resources/details/";

                if (File.Exists(detailPath + imageTitle + ".png"))
                    items[index].DetailPath = detailPath + imageTitle + ".png";
                if (File.Exists(detailPath + imageTitle + ".jpg"))
                    items[index].DetailPath = detailPath + imageTitle + ".jpg";
                if (File.Exists(detailPath + imageTitle + ".jpeg"))
                    items[index].DetailPath = detailPath + imageTitle + ".jpeg";
                if (File.Exists(detailPath + imageTitle + ".gif"))
                    items[index].DetailPath = detailPath + imageTitle + ".gif";

                if (items[index].DetailPath == null)
                    items[index].DetailPath = "/storage/emulated/0/Android/data/com.ugame.ugame/files/resources/unknown.png";

            }

            con.Close();
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}