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
        // Console.WriteLine(e.empId+" "+e.name);
        TempData["Empdtls"]=JsonConvert.SerializeObject(e);
        return RedirectToAction("EmpDetails");
    }

    public IActionResult EmpDetails()
    {
        Employee e=JsonConvert.DeserializeObject<Employee>(TempData["Empdtls"].ToString());
// Console.WriteLine(e.empId+" "+e.name);
     
        return View();
    }

    public IActionResult InsertEmp() {
        return View();
    }

    [HttpPost]
    public IActionResult InsertEmp(int empid,string name,string email,string password,double salary) {
        Employee emp=new Employee(empid,name,email,password,salary);
        bool status=DbManager.Insert(emp);

        if(status){
            return RedirectToAction("AllEmp");
        }
        else
        {
            return View();
        }
    }

    // public IActionResult DeleteEmp() {

    //     return View();
    // }

  //  [HttpPost]
    public IActionResult DeleteEmp(int empid) 
    {

        bool status=DbManager.Delete(empid);
        if(status){
            return RedirectToAction("AllEmp");
        }
        else
            return View();
    }

    public IActionResult UpdateEmp(int empid)
    {
        Employee e=DbManager.GetEmployee(empid);
        ViewBag["emp"]=e;
        return View();
    }

    [HttpPost]
    public IActionResult UpdateEmp(int empid,string name,string email,string password,double salary)
    {
        
        return null;
    }


}