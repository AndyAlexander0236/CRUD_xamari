using System;
using System.IO;
using Xamarin.Forms;
using XamarinSQLite;

namespace ejemploSQL
{
    public partial class App : Application
    {
        static SQLiteHelper db;

        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    db = new SQLiteHelper(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinSQLite.db3"));
                }
                return db;
            }
        }

        public App()
        {
            InitializeComponent(); // Este método debe existir aquí.
            MainPage = new MainPage();
        }

        // Otros métodos...
    }
}
