using System;
using System.ComponentModel;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using UGame.Models;
using UGame.ViewModels;
using SQLite;

namespace UGame.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Title = "Item 1",
                Platform = "This is an item description.",
                TimePlayed = "00h:00m:00s",
                Seconds = 0
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        Timer timer;
        int seconds = 0, hours = 0, minutes = 0;

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (Button1.Text == "Track")
            {
                Button1.Text = "Stop (00h:00m:00s)";

                timer = new Timer();
                timer.Interval = 1000;
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
            else
            {
                timer.Stop();
                Button1.Text = "Track";

                string path = @"/storage/emulated/0/Android/data/com.ugame.ugame/files/UGameDB.db";
                SQLite.SQLiteConnection con = new SQLite.SQLiteConnection(path);

                string id = viewModel.Item.Id;

                int totalSeconds = seconds + viewModel.Item.Seconds;
                while (totalSeconds >= 60)
                {
                    totalSeconds -= 60;
                    minutes++;
                }
                while (minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }

                string secString = seconds.ToString();
                string minString = minutes.ToString();
                string hrString = hours.ToString();

                if (seconds < 10)
                    secString = "0" + seconds;
                if (minutes < 10)
                    minString = "0" + minutes;
                if (hours < 10)
                    hrString = "0" + hours;

                string timePlayed = hrString + "h:" + minString + "m:" + secString + "s";

                // string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id + ";";
                // string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = ?";

                string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id;

                Console.WriteLine(funTime);
                con.Execute(funTime);

                //con.Close();

                seconds = 0;
            }
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            seconds++;

            // This doesn't work due to it being a cross-thread operation.
            /*
            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }

            string secString = seconds.ToString();
            string minString = minutes.ToString();
            string hrString = hours.ToString();

            if (seconds < 10)
                secString = "0" + seconds;
            if (minutes < 10)
                minString = "0" + minutes;
            if (hours < 10)
                hrString = "0" + hours;

            
            Button1.Text = "Stop (" + hrString + "h:" + minString + "m:" + secString + "s)";
            */
        }
    }
}