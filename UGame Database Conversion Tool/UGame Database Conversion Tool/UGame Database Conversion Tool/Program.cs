using IGDB;
using IGDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UGame_Database_Conversion_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put both the .accdb file and the .mdf file in this folder, then press any key.");
            Console.ReadKey();

            string mdfPath = GetExecutingDirectoryName();

            string newConString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"" + mdfPath + "\\UGameDB.mdf\";Integrated Security=True";
            string oldConString  = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Collection.accdb";

            SqlConnection newCon = new SqlConnection(newConString);
            OleDbConnection oldCon = new OleDbConnection(oldConString);

            // SqlCommand newCmd = new SqlCommand("INSERT INTO Games ([Title], [Platform], [Status], [Rating], [TimePlayed], [Seconds], [Obtained], [StartDate], [LastPlayed], [Notes], [URLs]) VALUES (@DateAdded, @NotificationType, @GameTitle, @Message, @Action);", con);
            OleDbCommand oldCmd = new OleDbCommand("SELECT * FROM Table1", oldCon);

            oldCmd.CommandType = CommandType.Text;
            OleDbDataAdapter da2 = new OleDbDataAdapter(oldCmd);
            DataTable gameTable = new DataTable();
            da2.Fill(gameTable);
            
            /*
            game.Id; // 4
            game.Name; // Thief
            */

            string title;
            string platform;
            string status;
            int rating;
            string playTime;
            string obtained;
            string startDate;
            string lastPlayed;
            string notes;
            string launch;
            string URLs;

            QueryTime();

            for (int index = 0; index < gameTable.Rows.Count; index++)
            {
                title = gameTable.Rows[index][1].ToString();
                platform = gameTable.Rows[index][2].ToString();
                status = gameTable.Rows[index][3].ToString();
                rating = Convert.ToInt32(gameTable.Rows[index][4]);
                playTime = gameTable.Rows[index][5].ToString();
                obtained = gameTable.Rows[index][6].ToString();
                startDate = gameTable.Rows[index][7].ToString();
                lastPlayed = gameTable.Rows[index][8].ToString();
                notes = gameTable.Rows[index][9].ToString();
                launch = gameTable.Rows[index][10].ToString();
                URLs = gameTable.Rows[index][11].ToString();
            }

            Console.ReadKey();
        }

        private static string GetExecutingDirectoryName()
        {
            var location = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            return new FileInfo(location.AbsolutePath).Directory.FullName;
        }

        private static async void QueryTime()
        {
            var igdb = IGDB.Client.Create("6588e966357049df69fa0ec8bd422e92");

            IGDB.Models.Search jeff = new Search();

            // var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "fields id,name; where id = 2;");
            var games = await igdb.QueryAsync<Game>(IGDB.Client.Endpoints.Games, query: "search \"Halo\"; fields name,release_dates.human;");
            var game = games.First();

            Console.WriteLine(game.Name);
            Console.WriteLine(game.ReleaseDates.Values[0].Human);
            Console.WriteLine(game.ReleaseDates.Values[0].Platform);
            Console.ReadKey();
        }
    }
}
