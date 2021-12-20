using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;

namespace Liono.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Evaluer : ContentPage
    {
        public Evaluer()
        {
            InitializeComponent();
        }

		public void GetProducts(Result result)
		{
			Device.BeginInvokeOnMainThread(async () =>
			{
				await Application.Current.MainPage.Navigation.PushModalAsync(new PopUp());
				await DisplayAlert("Scanned result", result.Text, "OK");

				
			});
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			_scanView.IsScanning = true;
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();

			_scanView.IsScanning = false;
		}
	}
}