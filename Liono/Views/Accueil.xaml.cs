using Liono.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using Xamarin.Forms;


namespace Liono.Views
{
    public partial class Accueil : ContentPage
    {
        //int count = 0;
        AccueilViewModel vm;
        public Accueil()
        {
            InitializeComponent();
            vm = Resources["vm"] as AccueilViewModel;
            
        }
        protected async override void OnAppearing()
        {
            if (!DialogViewModel.Instance.IsNotConnected)
                await vm.GetUserInfo();
        }


        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
            supprnone.IsVisible = false;
        }


        private async void Connection_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
            await vm.GetUserInfo();
        }

        private async void Creer_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void ImageButton21(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Favoris());
        }

        void NonMerci_Clicked(System.Object sender, System.EventArgs e)
        {
            nonmerc.IsVisible = false;
        }

    }
}

