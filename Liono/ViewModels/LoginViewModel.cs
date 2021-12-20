using Liono.Views;
using Liono.Services;
using Liono.Helpers;
using Xamarin.Forms;
using System.Windows.Input;
using System.ComponentModel;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Liono.ViewModels
{
    public class LoginViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public string Email { get; set; }
        public string Password { get; set; }
        public string Message { get; set; }

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //ApiServices apiServices = new ApiServices();

                    //await apiServices.LoginUserAsync(Email, Password);

                    var isConnect = await _apiServices.LoginUserAsync(Email, Password);

                    if (isConnect)
                    {
                        DialogViewModel.Instance.IsNotConnected = false;
                        DialogViewModel.Instance.IsAfficher = true;
                        await Application.Current.MainPage.Navigation.PushAsync(new Accueil());
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Email ou Mot de passe incorrect, merci de réessayer !", "Veuillez réessayer", "OK");
                    }

                });
            }
        }
        public LoginViewModel()
        {
            Email = Settings.Email;
            Password = Settings.Password;
        }
    }
}
