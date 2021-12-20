using Liono.Helpers;
using Liono.Services;
using Liono.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Liono.ViewModels
{
    public class SignUpViewModel
    {
        private readonly ApiServices _apiServices = new ApiServices();

        public string NomPrenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Message { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    //ApiServices apiServices = new ApiServices();

                    var isRegistered = await _apiServices.RegisterUserAsync(NomPrenom, Email, Password, ConfirmPassword);

                    Settings.Email = Email;
                    Settings.Password = Password;


                    if (isRegistered)
                    {
                        DialogViewModel.Instance.IsNotConnected = false;
                        DialogViewModel.Instance.IsAfficher = true;
                        await Application.Current.MainPage.Navigation.PushAsync(new Accueil());
                    }
                    else
                    {
                        await Application.Current.MainPage.DisplayAlert("Des informations sont incorrecte",
                            "Le mot de passe doit être composé d'un minimum de 6 caractères, de minuscule, de majuscules et de chiffres.", 
                            "OK");

                    }

                });
            }
        }
    }
}
