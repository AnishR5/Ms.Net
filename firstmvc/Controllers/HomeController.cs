using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstmvc.Models;

namespace firstmvc.Controllers;

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

    public IActionResult Aboutus()
    {
          Console.WriteLine(" Index HTTP Get Request Processing Logic is called..");
          return View();
            // var obj = new
            //     {
            //         Company = "CDAC",
            //         ContactPerson = "Anandi",
            //         Address = "Panchvati, Pashan, Pune"
            //     };

            //     return Json(obj);
    }

     [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email,string password)
    {
        Console.WriteLine(email+password);
        if(email.Equals("anishrachcha@gmail.com") && password.Equals("1234"))
        {
            return RedirectToAction("Welcome");
        }
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
