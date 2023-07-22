using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CompanyApp.Models;
using Newtonsoft.Json;

using BOL;
using DAL;

namespace CompanyApp.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    public IActionResult AllEmp()
    {
        List<Employee> emps=new List<Employee>();
        emps=DbManager.GetAllEmps();
        this.ViewData["employees"]=emps;
        return View();
    }

    [HttpGet]
    public IActionResult GetEmp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult GetEmp(int eid)
    {
        Employee e=DbManager.GetEmployee(eid);
        Console.WriteLine(e.empId+" "+e.name);
        TempData["Empdtls"]=JsonConvert.SerializeObject(e);
        return RedirectToAction("EmpDetails");
    }

    public IActionResult EmpDetails()
    {
        Employee e=JsonConvert.DeserializeObject<Employee>(TempData["Empdtls"].ToString());
Console.WriteLine(e.empId+" "+e.name);
     
        return View();
    }
}