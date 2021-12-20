using Liono.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;



namespace Liono.Views
{
    public partial class Profil : ContentPage
    {
        AccueilViewModel vm;
        public Profil()
        {
            InitializeComponent();
            vm = Resources["vm"] as AccueilViewModel;
        }

        protected async override void OnAppearing()
        {
            if (!DialogViewModel.Instance.IsNotConnected)
                await vm.GetUserInfo();
        }

        void ImageButton1_Clicked(System.Object sender, System.EventArgs e)
        {
            suppruunone.IsVisible = false;
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

        private async void MethodeCalcul(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MethodeCalcul());
        }

        private async void InfoPerso(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new InfoPerso());
           
        }

        private async void Favoris(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Favoris());
           
        }

        private async void ProtecDonnee(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ProtectionDonnees());
        }

        private async void BtnAide(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Aide());
        }

        private async void MentionsLegales(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MentionsLegales());
        }


        private async void OnLogoutButtonClicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ProfilDeco());
           
        }


    }
}