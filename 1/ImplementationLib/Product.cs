namespace ImplementationLib;
using SpecificationLib;

public class Product:ISellable
{
    private int id;
    private string title;
    private string description;
    private double unitPrice;
    private int quantity;

    public Product(int id,string title,string description,double unitPrice,int quantity)
    {
        this.id=id;
        this.title=title;
        this.description=description;
        this.unitPrice=unitPrice;
        this.quantity=quantity;
    }

     void ISellable.test()
    {
        Console.WriteLine("Product tested");
    }

     void ISellable.promote()
    {
        Console.WriteLine("Product promoted");
    }

     void ISellable.sell()
    {
        Console.WriteLine("Product sold");
    }


}
