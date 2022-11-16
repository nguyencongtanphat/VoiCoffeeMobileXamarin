using System;
using System.IO;
using SQLite;
using Xamarin.Forms;

[assembly:Dependency(typeof(VoiCoffee.Droid.SQLite_Android))]
namespace VoiCoffee.Droid
{
    public class SQLite_Android
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}
