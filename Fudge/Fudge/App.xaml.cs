using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace Fudge
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            VersionTracking.Track();

            var firstLaunch = VersionTracking.IsFirstLaunchEver;

            if (firstLaunch)
                MainPage = new NavigationPage(new Views.WelcomePage());
            else
                MainPage = new NavigationPage(new Views.MainTabbedPage());

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
