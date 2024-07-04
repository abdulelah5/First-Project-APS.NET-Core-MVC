using _101_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _101_Project.Controllers
{
    public class ProductsController : Controller
    {         
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //SqlConnection Conn = new SqlConnection();
            List<Product> Model = new List<Product>();
            Model.Add(new Product { ProductName = "Apple", ProductDetails = "Fresh apple from Riyadh", ProductPrice = 5 });
            Model.Add(new Product { ProductName = "Orange", ProductDetails = "Fresh orange from Yamammah", ProductPrice = 6 });
            Model.Add(new Product { ProductName = "Mango", ProductDetails = "Fresh Mango from south of Saudi", ProductPrice = 8 });
            Model.Add(new Product { ProductName = "Carrot", ProductDetails = "Fresh Carrot from wastren region", ProductPrice = 7 });
            Model.Add(new Product { ProductName = "Lemon", ProductDetails = "Fresh lemon from Hurrayeq", ProductPrice = 2 });
            Model.Add(new Product { ProductName = "Strawberry", ProductDetails = "Fresh strawberry from north of Saudi", ProductPrice = 4 });
            ViewData["ControllerProducts"] = Model;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact(string ProductName)
        {
            Product product = new Product();
            product.ProductName = ProductName;
            ViewData["city"] = product;


            return View();
        }

        public IActionResult Worksheet(string ProductName)
        {
            Product product = new Product();
            product.ProductName = ProductName;
            ViewData["city"] = product;


            return View();
        }

        /*public IActionResult Details()
        {
            return View();
        }*/

        [HttpGet]
        //[ValidateAntiForgeryToken]
        public IActionResult Details(string ProductName, int ProductPrice, string ProductDetails)
        {
            Product product = new Product();
            product.ProductName = ProductName;
            product.ProductPrice = ProductPrice;
            product.ProductDetails = ProductDetails;
            ViewData["data"] = product;

            return View();
        }           

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
