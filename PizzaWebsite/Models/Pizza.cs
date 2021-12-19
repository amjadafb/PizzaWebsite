using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaWebsite.Models
{
    public class Pizza
    {
        public int id { set; get; }
        public string type { set; get; }
        public int quantity { set; get; }
        public int price { set; get; }
    }
}