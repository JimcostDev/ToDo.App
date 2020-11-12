using System;
using ToDo.App.Data;
using ToDo.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDo.App
{
    public partial class App : Application
    {
        //initialize DatabaseContext
        public static DatabaseContext Context { get; set; }
        public App()
        {
            InitializeComponent();
            InitializeDatabase();
            MainPage = new NavigationPage(new HomePage());
        }

        private void InitializeDatabase()
        {
            var folderApp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
