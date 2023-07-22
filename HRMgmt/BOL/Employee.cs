namespace BOL;
[Serializable]
public class Employee
{
    public int empId {get;set;}
    public string name {get;set;}
    public string email  {get;set;}
    public string password {get;set;}
    public double salary {get;set;}

    public Employee(){

    }

    public Employee(int empid,string name,string email,string password,double salary){
        this.empId = empid;
        this.name = name;
        this.email = email;
        this.password = password;
        this.salary = salary;
    }

}
