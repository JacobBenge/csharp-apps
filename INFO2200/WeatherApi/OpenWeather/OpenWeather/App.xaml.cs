using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OpenWeather
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Makes the app a multipage app
            MainPage = new NavigationPage( new MainPage());
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
