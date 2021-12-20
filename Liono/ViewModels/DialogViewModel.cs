using Liono.Helpers;
using Liono.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Liono.ViewModels
{
    public  class DialogViewModel:BaseViewModel
    {

        private bool _isNotConnected = true;
        public bool IsNotConnected
        {
            get => _isNotConnected;
            set
            {
                _isNotConnected = value;
                RaisePropertyChange();
            }
        }

        private bool _isAfficher = false;
        public bool IsAfficher
        {
            get => _isAfficher;
            set
            {
                _isAfficher = value;
                RaisePropertyChange();
            }
        }


        public ApiServices ApiServices { get; set; }

        private static DialogViewModel _instance = null;

        public static DialogViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DialogViewModel();
                return _instance;

            }
        }

        public DialogViewModel()
        {
            ApiServices = new ApiServices();

        }


        
    }
}
