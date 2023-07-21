namespace HRlib;

public class SalesManager:Employee{
    public double incentive { get; set; }=0;

    public SalesManager():base()
    {}

    public SalesManager(int empid, string name, int age,double salary,string email,double incentive):base(empid,name,age,salary,email){
        this.incentive=incentive;        
   }

    public override double totalSal()
    {
        return salary+incentive;
    }

    public override string ToString()
    {
        return base.ToString()+" "+ incentive;
    }


}