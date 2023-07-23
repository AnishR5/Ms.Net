namespace EmployeeMgmt.Models;

[Serializable]
public class Employee{
    public int id { get; set;}
    public string name { get; set;}
    public string email { get; set;}
    public double salary { get; set;}

    public Employee(int id, string name, string email,double salary) {
        this.id = id;
        this.name = name;
        this.email = email;
        this.salary = salary;
    }   
}