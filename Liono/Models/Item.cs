using System;
using System.Collections.Generic;
using System.Text;

namespace Liono.Models
{
    public class Item
    {
        public double ean { get; set; }
        public double imapct { get; set; }
        public string price { get; set; }
        public string title { get; set; }
    }

    public class Root
    {
        public Item item { get; set; }
    }

}
