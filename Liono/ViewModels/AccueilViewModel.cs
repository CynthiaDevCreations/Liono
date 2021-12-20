using Liono.Models;
using System;
using Liono.Views;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Liono.Helpers;
using System.Diagnostics;

namespace Liono.ViewModels
{
    public class AccueilViewModel : BaseViewModel
    {
        private UserModel _userModel;
        public UserModel UserModel
        {
            get => _userModel;
            set
            {
                _userModel = value;
                RaisePropertyChange();
            }
        }

        public AccueilViewModel()
        {

        }

        public async Task GetUserInfo()
        {
            try
            {
                UserModel = await DialogViewModel.Instance.ApiServices.GetUserInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


    }


}

