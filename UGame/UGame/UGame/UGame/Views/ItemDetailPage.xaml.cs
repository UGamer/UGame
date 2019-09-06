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
                Plugin.LocalNotifications.CrossLocalNotifications.Current.Show("UGame", "Playing \"" +  viewModel.Item.Title + "\"", 0);
            }
            else
            {
                timer.Stop();
                Button1.Text = "Track";

                string path = @"/storage/emulated/0/Android/data/com.ugame.ugame/files/UGameDB.db";
                SQLite.SQLiteConnection con = new SQLite.SQLiteConnection(path);

                string id = viewModel.Item.Id;

                int totalSeconds = seconds + viewModel.Item.Seconds;

                int sec = totalSeconds;
                while (sec >= 60)
                {
                    sec -= 60;
                    minutes++;
                }
                while (minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }

                string secString = sec.ToString();
                string minString = minutes.ToString();
                string hrString = hours.ToString();

                if (sec < 10)
                    secString = "0" + sec;
                if (minutes < 10)
                    minString = "0" + minutes;
                if (hours < 10)
                    hrString = "0" + hours;

                string timePlayed = hrString + "h:" + minString + "m:" + secString + "s";

                // string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id + ";";
                // string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = ?";

                string funTime = "UPDATE Games SET TimePlayed = '" + timePlayed + "', Seconds = " + totalSeconds + ", LastPlayed = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE Id = " + id;

                viewModel.Item.TimePlayed = timePlayed;
                viewModel.Item.LastPlayed = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                TimePlayedLabel.Text = timePlayed;
                LastPlayedLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                con.TableChanged += Connection_TableChanged;
                con.TimeExecution = true;
                con.Trace = true;

                Console.WriteLine(funTime);

                con.BeginTransaction();
                con.Execute(funTime);
                con.Commit();

                con.Close();
                con.Dispose();

                minutes = 0;
                hours = 0;
                while (sec >= 60)
                {
                    sec -= 60;
                    minutes++;
                }
                while (minutes >= 60)
                {
                    minutes -= 60;
                    hours++;
                }

                string alertMessage = "You played " + viewModel.Item.Title + " for ";

                if (hours > 1 && minutes == 0 && seconds == 0)
                    alertMessage += hours.ToString() + " hours.";
                if (hours == 1 && minutes == 0 && seconds == 0)
                    alertMessage += hours.ToString() + " hour.";
                if (hours > 1 && (minutes != 0 || seconds != 0))
                    alertMessage += hours.ToString() + " hours, ";

                if (minutes > 1 && seconds == 0)
                    alertMessage += minutes.ToString() + " minutes.";
                if (minutes == 1 && seconds == 0)
                    alertMessage += minutes.ToString() + " minute.";
                if (minutes > 1 && seconds != 0)
                    alertMessage += minutes.ToString() + " minutes, ";

                if (seconds > 1)
                    alertMessage += seconds.ToString() + " seconds.";
                if (seconds == 1)
                    alertMessage += seconds.ToString() + " second.";


                DisplayAlert("Play Session Complete", alertMessage, "OK");

                seconds = 0;
                minutes = 0;
                hours = 0;

                Plugin.LocalNotifications.CrossLocalNotifications.Current.Cancel(0);

            }
        }

        private void Connection_TableChanged(object sender, NotifyTableChangedEventArgs e)
        {
            Console.WriteLine("Successful!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            seconds++;

            
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

            string playSession = hrString + "h:" + minString + "m:" + secString + "s";
            // This doesn't work due to it being a cross-thread operation.
            /*
            Button1.Text = "Stop (" + hrString + "h:" + minString + "m:" + secString + "s)";
            */
        }
    }
}