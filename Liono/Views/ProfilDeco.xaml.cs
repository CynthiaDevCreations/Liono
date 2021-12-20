using Liono.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Liono.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilDeco : ContentPage
    {
        AccueilViewModel vm;
        public ProfilDeco()
        {
            InitializeComponent();
            vm = Resources["vm"] as AccueilViewModel;
        }

        void ImageButt_Clicked(System.Object sender, System.EventArgs e)
        {
            supnone.IsVisible = false;
        }
        private async void Connect_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
            await vm.GetUserInfo();
        }

        private async void Cre_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void MethodeCalcu(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MethodeCalcul());
        }
        private async void ProtecDonne(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ProtectionDonnees());
        }

        private async void BtnAid(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Aide());
        }

        private async void MentionsLegale(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MentionsLegales());
        }
        
    }
}