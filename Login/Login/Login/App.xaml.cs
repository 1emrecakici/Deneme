using Login.Services;
using Login.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            /*DependencyService.Register<MockDataStore>();*/
            /* MainPage = new NavigationPage(new SettingsPage());*/
            string uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
            {
                MainPage = new LoginView();
            }
            else
            {
                MainPage = new ProductsView();
            }
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
