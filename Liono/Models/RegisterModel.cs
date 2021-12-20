using System;
using System.Collections.Generic;
using System.Text;

namespace Liono.Models
{
    public class RegisterModel
    {
        public string NomPrenom { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
