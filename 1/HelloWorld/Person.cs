namespace HR;

public class Person{
    private String fName;
    private String lName;
    private DateTime birthDate;
    private String contactNum;
    private String email;
    //proterty
    public string FName{
        get{return this.fName;}
        set{this.fName=value;}
    }

    public Person() {}
    public Person(String fName,String lName,DateTime birthDate, String contactNum,String email)
    {
        this.fName=fName;
        this.lName=lName;
        this.birthDate=birthDate;
        this.contactNum=contactNum;
        this.email=email;
    }

    public override String ToString()
    {
        string data=base.ToString();
        Console.WriteLine(data+"\n");
        return data + this.fName+" "+this.lName+" "+this.birthDate+" "+this.contactNum+" "+this.email;
    }

}