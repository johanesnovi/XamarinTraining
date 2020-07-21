using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //ubah untuk halaman yang pertama kali muncul
            //MainPage = new MainPage();
            //MainPage = new samplegridlayout();
            //MainPage = new sampleliststring();
            MainPage = new samplelistbinding();
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
