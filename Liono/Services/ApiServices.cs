using Liono.Models;
using Liono.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace Liono.Services
{
    public class ApiServices
    {
        public readonly string baseUrl = "https://lionoapicore.azurewebsites.net/";
        //public readonly string baseUrl = "http://localhost:63692/";


        // POUR L'ENREGISTREMENT D'UN UTILISATEUR
        public async Task<bool> RegisterUserAsync(string nomprenom, string email, string password, string confirmPassword)
        {
            var client = new HttpClient();

            var model = new RegisterModel
            {
                NomPrenom = nomprenom,
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent content = new StringContent(json);

            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync($"{baseUrl}users/register", content);

            Debug.WriteLine(response);
            Debug.WriteLine(await response.Content.ReadAsStringAsync());
            Debug.WriteLine(response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }



        //POUR SE CONNECTER

        public async Task<bool> LoginUserAsync(string email, string password)
        {
            var client = new HttpClient();

            var model = new Login
            {
                Email = email,
                Password = password
            };

            var json = JsonConvert.SerializeObject(model);

            HttpContent httpContent = new StringContent(json);

            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await client.PostAsync($"{baseUrl}users/authenticate", httpContent);

            var content = await response.Content.ReadAsStringAsync();
            JObject jwtDynamic = JsonConvert.DeserializeObject<dynamic>(content);
            var accessTokenExpiration = jwtDynamic.Value<DateTime>(".expires");
            var accessToken = jwtDynamic.Value<string>("token");
            var id = jwtDynamic.Value<int>("id");
            Settings.AccessTokenExpirationDate = accessTokenExpiration;
            Settings.AccessToken = accessToken;
            Settings.Id = id;

            Debug.WriteLine(response);
            Debug.WriteLine(await response.Content.ReadAsStringAsync());
            //return accessToken;

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            return false;

        }

        // SE DECONNECTER


        //AFFICHER LE NOM

        public async Task<UserModel> GetUserInfo()
        //public async Task<List<UserModel>> GetUserInfo()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Settings.AccessToken);
            client.BaseAddress = new Uri(baseUrl);
            //client.DefaultRequestHeaders.Add("id", Settings.Id.ToString());
            var response = await client.GetStringAsync($"{baseUrl}users/{Settings.Id.ToString()}");
            if (response == null)
                return null;
            var user = JsonConvert.DeserializeObject<UserModel>(response);
            if (user == null)
                return null;
            return user;



        }



    }
}
