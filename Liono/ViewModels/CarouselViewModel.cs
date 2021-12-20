using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Xamarin.Forms;
using Liono.Models;

namespace Liono.ViewModels
{
    public class CarouselViewModel
    {

        public CarouselViewModel()
        {
            ImageCollection.Add(new CarouselModel("Onboarding1.png"));
            ImageCollection.Add(new CarouselModel("Onboarding2.png"));
            ImageCollection.Add(new CarouselModel("Onboarding3.png"));
            ImageCollection.Add(new CarouselModel("Onboarding4.png"));
        }
        private List<CarouselModel> imageCollection = new List<CarouselModel>();
        public List<CarouselModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
