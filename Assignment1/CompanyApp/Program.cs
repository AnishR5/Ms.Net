using System.Collections.Generic;
using HRlib;
using Taxation;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<Employee> employees = new List<Employee>();

while (true)
{ 
       Console.WriteLine("1.Add Employee 2.Remove emp 3.Show All Employees 4.Compute process salary 5. No.of Employees salary processed 6.Total Amount spent");
       Console.WriteLine("Enter Operation");
       //int choice=Double.Parse(Console.Read());
       int choice=int.Parse(Console.ReadLine());
       Console.WriteLine(choice);
    switch (choice)
    {  
        case 1:
            Console.WriteLine("1.Add SalesManager 2.Add SalesEmployee");
            int ch=int.Parse(Console.ReadLine());
            if(ch==1)
            {
                Console.WriteLine("Enter empid, name,age,salary,email,incentive");
                //int empid, string name, int age,double salary,string email,double incentive
                Employee emp = new SalesManager(int.Parse(Console.ReadLine()),Console.ReadLine(),int.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),Console.ReadLine(),double.Parse(Console.ReadLine()));
                employees.Add(emp);
                Console.WriteLine("SalesManager added ");
            }
            else{
                 Console.WriteLine("Enter empid, name,age,salary,email,bonus");
                 //int empid, string name, int age,double salary,string email,double bonus
                Employee emp = new SalesEmployee(int.Parse(Console.ReadLine()),Console.ReadLine(),int.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()),Console.ReadLine(),double.Parse(Console.ReadLine()));
                employees.Add(emp);
                Console.WriteLine("SalesEmployee added ");
            }
            break;

        case 2:
            Console.WriteLine("Enter employee id");
            int id=int.Parse(Console.ReadLine());
            

            break;

        case 5:
            employees.ForEach(emp => Console.WriteLine(emp+" "));
            break;
        
        
    }
}

