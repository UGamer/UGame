using Microsoft.Toolkit.Uwp.UI.Controls;
using System;
using System.Data;
using System.Data.SQLite;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace UGame.Views
{
    public sealed partial class GamesPage : Page, INotifyPropertyChanged
    {

        public GamesPage()
        {
            Config config = new Config();

            InitializeComponent();

            FillDataGrid(GameGrid);
        }

        public static void FillDataGrid(DataGrid grid)
        {
            string connectionString = "Data Source=UGameDB.db;Version=3;";
            // string connectionString = "Data Source=" + config.databasePath + ";Version=3;";
            SQLiteConnection con = new SQLiteConnection(connectionString);
            SQLiteCommand titleCmd = new SQLiteCommand("SELECT Title FROM Games", con);
            SQLiteCommand fullCmd = new SQLiteCommand("SELECT * FROM Games", con);
            DataTable gameTable, fullTable;

            titleCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da = new SQLiteDataAdapter(titleCmd);
            gameTable = new DataTable();
            da.Fill(gameTable);

            fullCmd.CommandType = CommandType.Text;
            SQLiteDataAdapter da2 = new SQLiteDataAdapter(fullCmd);
            fullTable = new DataTable();
            da2.Fill(fullTable);

            gameTable.DefaultView.Sort = "Title";
            gameTable = gameTable.DefaultView.ToTable();

            grid.Columns.Clear();

            for (int i = 0; i < gameTable.Columns.Count; i++)
            {
                grid.Columns.Add(new DataGridTextColumn()
                {
                    Binding = new Binding { Path = new PropertyPath("[" + i.ToString() + "]") }
                });
            }

            var collection = new ObservableCollection<object>();
            foreach (DataRow row in gameTable.Rows)
            {
                collection.Add(row.ItemArray);
                // collection.Add(row["Title"].ToString());
            }

            grid.ItemsSource = collection;

            
        }

        private void GameGrid_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
