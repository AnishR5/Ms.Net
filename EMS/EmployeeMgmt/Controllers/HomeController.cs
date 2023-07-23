using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmployeeMgmt.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EmployeeMgmt.Controllers;

public class HomeController : Controller
{
    List<Employee> emps=new List<Employee>();
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

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(int eid,string name,string email, double salary)
    {
        Employee emp=new Employee(eid,name,email,salary);
        emps.Add(emp);
        try{
            var options=new JsonSerializerOptions {IncludeFields=true};
            var employeeJson=JsonSerializer.Serialize<List<Employee>>(emps,options);
            string fileName=@"E:\Iacsd\MsnetWs\EMS\Employees.json";
            System.IO.File.WriteAllText(fileName,employeeJson);
           //File.WriteAllText(fileName, employeeJson);
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return RedirectToAction("Index");

    }

    public IActionResult List()
    {
        var options=new JsonSerializerOptions {IncludeFields=true};
        string fileName=@"E:\Iacsd\MsnetWs\EMS\Employees.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<Employee> jsonEmployee = JsonSerializer.Deserialize<List<Employee>>(jsonString);
        this.ViewData["Employees"]=jsonEmployee;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
