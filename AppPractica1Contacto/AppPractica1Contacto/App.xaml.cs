using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppPractica1Contacto
{
    public partial class App : Application
    {
        private static Model.Database instance;
        public static Model.Database Instance
        {
            get
            {
                if (instance == null)
                    instance = new Model.Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Contacto.db3"));
                return instance;
            }
        }



        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
