using System;
using Main;
using System.IO;
using Xamarin.Forms;
using Madplan.Droid;

[assembly: Dependency(typeof(FileHelper))]
namespace Madplan.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetConnection()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, "MyDataMadplanVbk.db");
        }
    }
}