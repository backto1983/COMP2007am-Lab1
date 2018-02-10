using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<string> products = new List<string>();
            products.Add("Laptop");
            products.Add("Tablet");
            products.Add("Desktop");

            return View();
        }

        public ActionResult Details(string product)
        {
            if (product == null)
                return View("Error");

            ViewBag.Product = "You selected product: " + product;     

            return View();
        }
    }
}