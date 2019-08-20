using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGame.Classes
{
    public class Entry
    {
        public int[] id;

        public string title;
        public string[] platforms;
        public string[] status;
        public int[] rating;
        public string[] timePlayed;
        public int[] seconds;
        public DateTime[] obtained;
        public DateTime[] startDate;
        public DateTime[] lastPlayed;
        public string[] notes;
        public string[] urls;
        public string[] filters;
        public string[] developers;
        public string[] publishers;
        public DateTime[] releaseDate;
        public string[] genre;
        public string[] price;
        public string[] gameDesc;
        public string[] launchCode;
        public string[] blurCheck;
        public string[] overlayCheck;
        public string[] discordCheck;

        public bool tracking = false;

        public Entry()
        {

        }
    }
}
