using Liono.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Liono.Services
{
    class ApiService
    {

        public class Item
        {
            public double ean { get; set; }
            public double imapct { get; set; }
            public string price { get; set; }
            public string title { get; set; }

            public class Root
            {
                public Item item { get; set; }
            }



        }

    }
}
