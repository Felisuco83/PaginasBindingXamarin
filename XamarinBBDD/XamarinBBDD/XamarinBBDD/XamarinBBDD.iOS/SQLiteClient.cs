using Foundation;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using XamarinBBDD.Dependencies;
using XamarinBBDD.iOS;

[assembly: Dependency(typeof(SQLiteClient))]
namespace XamarinBBDD.iOS
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            string bbddfile = "HOSPITAL.db";
            string rutadocuments = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string librarypath = Path.Combine(rutadocuments, "..", "Library", "Databases");
            if(Directory.Exists(librarypath) == false)
            {
                Directory.CreateDirectory(librarypath);
            }
            string path = Path.Combine(librarypath, bbddfile);
            SQLiteConnection cn = new SQLiteConnection(path);
            return cn;
        }
    }
}