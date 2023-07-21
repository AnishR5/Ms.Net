namespace Drawing;

public abstract class Shape{
    private int width;
    private string color;

    public Shape()
    {
        width=2;
        color="black";
    }

    public Shape(int width,string color)
    {
        this.width=width;
        this.color=color;
    }

    public int Width{
        set{this.width=value;}
        get{return this.width;}
    }

    public string Color{
        set{this.color=value;}
        get{return this.color;}
    }

    public override string ToString()
    {
        return "width:"+this.width+" color:"+color;
    }

    public abstract void Draw(); 

}