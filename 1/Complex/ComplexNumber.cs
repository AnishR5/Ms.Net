namespace Complex;

public class ComplexNumber
{
    private int real;
    private int imag;

    public ComplexNumber()
    {
        real=0;
        imag=0;
    }
    public ComplexNumber(int real, int imag)
    {
        this.real=real;
        this.imag=imag;
    }
    public int rl{
        get{return this.real;}
        set{this.real=value;}
    }

    public int img{
        get{return this.imag;}
        set{this.imag=value;}
    }

    // public override string ToString()
    // {
    //     return "("+this.real+","+this.imag+")";
    // }

    public override string ToString()
    {
        string data=String.Format("({0},{1}j)",this.real,this.imag);
        return data;
    }


    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber temp=new ComplexNumber();
        temp.real=a.real+b.real;
        temp.imag=a.imag+b.imag;
        return temp;
    }

}
