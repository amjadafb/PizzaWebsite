using PizzaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaWebsite.Controllers
{
    public class CheckoutController : Controller
    {
        // GET: Checkout
        public ActionResult Index()
        {
            List<Pizza> lstPizza = (List<Pizza>)Session["Pizzalst"];
            int total = 0;
            for (int i = 0; i < lstPizza.Count; i++)
            {
                total += lstPizza[i].quantity * lstPizza[i].price;
            }
            ViewBag.Total = total;
            return View(lstPizza);
        }
        public ActionResult Confirm()
        {
            return RedirectToAction("Index", "Confirmation");
        }
        public ActionResult Back()
        {
            return RedirectToAction("Index", "Pizza");
        }
    }
}