namespace HRlib;

public class SalesEmployee:Employee
{
    public double bonus { get; set; }= 0;

    public SalesEmployee(int empid, string name, int age,double salary,string email,double bonus):base(empid,name,age,salary,email)
    {
        this.bonus = bonus;
    }

    public SalesEmployee():base(){}

    public override double totalSal()
    {
        return  bonus+salary;
    }

    public override string ToString()
    {
        return base.ToString()+" "+bonus;
    }

}