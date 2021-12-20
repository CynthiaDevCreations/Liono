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
    public partial class PopUp : ContentPage
    {
        public PopUp()
        {
            InitializeComponent();
        }

        private async void Detail_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VosProduits());
        }
    }
}