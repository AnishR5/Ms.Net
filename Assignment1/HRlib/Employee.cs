namespace HRlib;

public abstract class Employee
{
    public int empid;
    public string name  ;
    public int age { get; set; } =0;
    public double salary { get; set; } = 0;
    public string email { get; set;}=string.Empty;

    public int Empid{
        get { return empid; }
        set { empid = value; }
    }

    public Employee(int empid, string name, int age,double salary,string email)
    {
        this.empid = empid;
        this.name = name;
        this.age = age;
        this.salary = salary;
        this.email = email;
    }

    public Employee():this(101,"Anish",22,50000,"anishrachcha@gmail.com") //ctor chaining
    {}

    public abstract double totalSal();

    public override string ToString()
    {
        return empid+" "+name+" "+age+" "+salary+" "+email;
    }



}

