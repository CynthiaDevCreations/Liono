using System.Linq;
using System.Text;
using Xamarin.Essentials;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System;

namespace Liono.Views
{
    public partial class ProtectionDonnees : ContentPage
    {
        public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ProtectionDonnees()
        {
            InitializeComponent();
            BindingContext = this;
        }

        async void Site_Extern(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.economie.gouv.fr/dgccrf/Publications/Vie-pratique/Fiches-pratiques/protection-des-donnees-personnelles-quels-sont-droits");


        }
    }
}