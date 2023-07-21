namespace Drawing;

public class Line:Shape{
    private Point startPoint;
    private Point endPoint;

    public Line():base(){
        this.startPoint=new Point();
        this.endPoint=new Point();
    }

    public Line(Point p1,Point p2,int width,string color):base(width,color)
    {
        this.startPoint=p1;
        this.endPoint=p2;
    }

    public Point StartPoint{
        get{return this.startPoint;}
        set{this.startPoint=value;}
    }

    public Point EndPoint{
        get{return this.endPoint;}
        set{this.endPoint=value;}
    }

    public override void Draw()
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
       return base.ToString()+" p1:"+startPoint+" p2:"+endPoint;
    }

}