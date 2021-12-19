using PizzaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaWebsite.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {

            List<Pizza> lstPizza = new List<Pizza>();
            if (Session["Pizzalst"] == null)
            {
                lstPizza.Add(new Pizza { id = 101, type = "Pepperoni", quantity = 0, price = 20 });
                lstPizza.Add(new Pizza { id = 102, type = "Margherita", quantity = 0, price = 22 });
                lstPizza.Add(new Pizza { id = 103, type = "Mushroom", quantity = 0, price = 24 });
                lstPizza.Add(new Pizza { id = 104, type = "Mexican", quantity = 0, price = 26 });
                Session["Pizzalst"] = lstPizza;
            }
            lstPizza = (List<Pizza>)Session["Pizzalst"];
            return View(lstPizza);
        }
        public ActionResult Add(int id)
        {
            List<Pizza> lstPizza = (List<Pizza>)Session["Pizzalst"];
            for (int i =0; i< lstPizza.Count; i++)
            {
                if(lstPizza[i].id == id)
                {
                    lstPizza[i].quantity++;
                }
            }
            Session["Pizzalst"] = lstPizza;
            return RedirectToAction("Index");
        }
        public ActionResult Checkout()
        {
            return RedirectToAction("Index", "Checkout");
        }
    }
}