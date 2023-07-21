namespace Drawing;

public struct Point
{
    private int x;
    private int y;

    public Point(){
        this.x=0;
        this.y=0;
    }

    public Point(int x,int y)
    {
        this.x=x;
        this.y=y;
    }

    public override string ToString()
    {
        string data=String.Format("({0},{1})",this.x,y);
        return data;
    }

}
