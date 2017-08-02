using System;
using System.IO;
using Madplan.Persistance;
using SQLite;
using Madplan.Droid.Persistance;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace Madplan.Droid.Persistance
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite_FST.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}