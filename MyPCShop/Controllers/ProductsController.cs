using Microsoft.AspNetCore.Mvc;
using MyPCShop.Models;
using System.Collections.Generic;

namespace MyPCShop.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult ViewProducts()
        {
            var products = new List<Products>
            {
                new Products{ Id=1, Name="Gaming Keyboard", Price="LKR 5,500" },
                new Products { Id=2, Name="Wireless Mouse", Price="LKR 3,200" },
                new Products { Id=3, Name="Laptop Stand", Price="LKR 2,500" }
            };
            return View(products);
        }
    }
}
