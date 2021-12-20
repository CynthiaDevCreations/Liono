using System;
using System.Collections.Generic;
using System.Text;
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace Liono.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        public static string NomPrenom
        {
            get
            {
                return AppSettings.GetValueOrDefault("Nom & Prénom", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Nom & Prénom", value);
            }
        }


        public static string Email
        {
            get
            {
                return AppSettings.GetValueOrDefault("Email", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Email", value);
            }
        }
        public static string Password
        {
            get
            {
                return AppSettings.GetValueOrDefault("Password", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("Password", value);
            }
        }
        public static string AccessToken
        {
            get
            {
                return AppSettings.GetValueOrDefault("AccessToken", "");
            }
            set
            {
                AppSettings.AddOrUpdateValue("AccessToken", value);
            }
        }

        public static DateTime AccessTokenExpirationDate
        {
            get
            {
                return AppSettings.GetValueOrDefault("AccessTokenExpirationDate", DateTime.UtcNow);
            }
            set
            {
                AppSettings.AddOrUpdateValue("AccessTokenExpirationDate", value);
            }
        }

        public static int Id
        {
            get
            {
                return AppSettings.GetValueOrDefault("ID", 0);
            }
            set
            {
                AppSettings.AddOrUpdateValue("ID", value);
            }
        }
    }
}
