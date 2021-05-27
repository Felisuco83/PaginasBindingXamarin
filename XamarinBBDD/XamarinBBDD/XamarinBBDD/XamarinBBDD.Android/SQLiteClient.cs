using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinBBDD.Dependencies;
using XamarinBBDD.Droid;

[assembly: Dependency(typeof(SQLiteClient))]
namespace XamarinBBDD.Droid
{
    public class SQLiteClient : IDataBase
    {
        public SQLiteConnection GetConnection()
        {
            string bbddfile = "HOSPITAL.db3";
            string rutadocumentos = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string path = Path.Combine(rutadocumentos, bbddfile);
            SQLiteConnection cn = new SQLiteConnection(path);
            return cn;
        }
    }
}