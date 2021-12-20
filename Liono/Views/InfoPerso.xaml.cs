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
    public partial class InfoPerso : ContentPage
    {
        public InfoPerso()
        {
            InitializeComponent();
        }

        public async void ModifMotPass(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new InfoPersoChangePass());
        }

        public async void ChangeAdress(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new InfoPersoChangeEmail());
        }
    }
}