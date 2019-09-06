using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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

            items = con.Query<Item> ("SELECT \"Id\" AS \"Id\", \"Title\" AS \"Title\", \"Platform\" AS \"Platform\", \"TimePlayed\" AS \"TimePlayed\", \"Seconds\" AS \"Seconds\" FROM Games ORDER BY Title");
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