using System;

namespace UGame.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Platform { get; set; }
        public string TimePlayed { get; set; }
        public int Seconds { get; set; }
        public string LastPlayed { get; set; }
        public string IconPath { get; set; }
        public string DetailPath { get; set; }
    }
}