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
    public partial class Carrousel : ContentPage
    {
        public Carrousel()
        {
            InitializeComponent();
            this.BindingContext = new CarouselViewModel();
        }

        private void Carousel_SwipeStarted(object sender, Syncfusion.SfCarousel.XForms.SwipeStartedEventArgs e)
        {
            // Trigger when swipe starts in the carousel item.
            carousel.IsVisible = false;
        }

        private void Carousel_SwipeEnded(object sender, EventArgs e)
        {
            // Trigger before swipe ends in the carousel item.
            carousel.IsVisible = false;
            //await Navigation.PushAsync(new Accueil());
        }
    }
}