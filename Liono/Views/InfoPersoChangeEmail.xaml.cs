using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Liono.Views
{
    public partial class InfoPersoChangeEmail : ContentPage
    {
        public InfoPersoChangeEmail()
        {
            InitializeComponent();
        }

        public async void AnnulModif2(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Profil());
        }
    }
}
