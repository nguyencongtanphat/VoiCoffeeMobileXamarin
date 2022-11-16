using System;
using System.IO;
using SQLite;
using VoiCoffee.Model;
using Xamarin.Forms;

[assembly:Dependency(typeof(VoiCoffee.iOS.SQLite_iOS))]
namespace VoiCoffee.iOS
{
    public class SQLite_iOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFileName = "MyDatabase.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(libraryPath, sqliteFileName);
            var cn = new SQLiteConnection(path);
            return cn;
        }
    }
}
