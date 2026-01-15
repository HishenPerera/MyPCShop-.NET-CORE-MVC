using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPCShop.Models;

namespace MyPCShop.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }
}
