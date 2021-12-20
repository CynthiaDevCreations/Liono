using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;


namespace Liono.Views
{
    public partial class MethodeCalcul : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public MethodeCalcul()
        {
            InitializeComponent();
            BindingContext = this;

        }


        async void Site_ADEME(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.ademe.fr/");

        }
    }
}
