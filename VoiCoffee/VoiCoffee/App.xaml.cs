using System;
using VoiCoffee.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VoiCoffee
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new LoginView();
            MainPage = new NavigationPage(new SettingsPage());
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
