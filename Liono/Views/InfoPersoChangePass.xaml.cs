using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Liono.Views
{
    public partial class InfoPersoChangePass : ContentPage
    {
        public InfoPersoChangePass()
        {
            InitializeComponent();
        }

        public async void AnnulModif(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Profil());
        }
    }
}
