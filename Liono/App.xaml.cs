using Liono.Helpers;
using Liono.Services;
using Liono.ViewModels;
using Liono.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Liono
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //MainPage=new NavigationPage(new CarouselPage());   

            //SetMainPage();
        }

        //private void SetMainPage()
        //{
        //    if (!string.IsNullOrEmpty(Settings.AccessToken))
        //    {
        //        if (Settings.AccessTokenExpirationDate < DateTime.UtcNow.AddHours(1))
        //        {
        //            //var loginViewModel = new LoginViewModel();
        //            //loginViewModel.LoginCommand.Execute(null);
        //            //MainPage = new AppShell();
        //        }
        //        MainPage = new AppShell();
        //    }
        //    else if (!string.IsNullOrEmpty(Settings.Email)
        //          && !string.IsNullOrEmpty(Settings.Password))
        //    {
        //        MainPage = new NavigationPage(new Accueil());
        //    }
        //    else
        //    {
        //        MainPage = new NavigationPage(new Profil());
        //    }
        //}

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
