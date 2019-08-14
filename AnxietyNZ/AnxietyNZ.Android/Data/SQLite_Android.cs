using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AnxietyNZ.Data;
using System.IO;
using Xamarin.Forms;
using AnxietyNZ.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]

namespace AnxietyNZ.Droid.Data
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite_Android.SQLiteConnection(path);

            return conn;
        }
    }
}