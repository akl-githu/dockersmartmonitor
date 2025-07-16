using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using smartmonitor.Models;

namespace smartmonitor.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult RedirectPage(string userType)
    {
        if (userType == "admin")
        {
            return RedirectToAction("AdminPage");
        }
        else if (userType == "viewer")
        {
            return RedirectToAction("ViewerPage");
        }
        return RedirectToAction("SignIn");
    }

    public IActionResult SignIn()
    {
        return View();
    }

    
}
