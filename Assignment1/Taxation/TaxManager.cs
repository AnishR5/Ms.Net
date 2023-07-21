namespace Taxation;

public class TaxManager
{
    public double takeHomeSal(double totalSalary,double tax){
        return totalSalary*((100-tax)/100);
    }
}
