using Liono.ViewModels;
using Liono.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Liono
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            //NavigationPage.SetHasNavigationBar(this,false);
        }

    }
}
