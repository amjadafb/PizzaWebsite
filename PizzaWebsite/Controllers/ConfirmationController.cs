using PizzaWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaWebsite.Controllers
{
    public class ConfirmationController : Controller
    {
        // GET: Confirmation
        public ActionResult Index()
        {
            List<Pizza> lstPizza = (List<Pizza>)Session["Pizzalst"];
            List<Pizza> lstConfirmedPizza = new List<Pizza>();
            int total = 0;
            for (int i = 0; i < lstPizza.Count; i++)
            {
                if (lstPizza[i].quantity > 0)
                {
                    lstConfirmedPizza.Add(lstPizza[i]);
                    total += lstPizza[i].quantity * lstPizza[i].price;
                }                
            }
            ViewBag.OrderNo = DateTime.Now.ToString("yyMMddHHMMss")+"_"+ total;
            ViewBag.Total = total;
            return View(lstConfirmedPizza);
        }
        public ActionResult Back()
        {
            Session["Pizzalst"] = null;
            return RedirectToAction("Index", "Pizza");
        }
    }
}