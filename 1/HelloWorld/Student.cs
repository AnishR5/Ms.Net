namespace STUD;
using System;
using HR;
public class Student:Person{
    private int rollNo;
    private DateTime registrationDate;
    private String course;
    private static int count;

    public Student()
    {
        count++;
    }
    public Student(int rollNo,DateTime registrationDate,String course,String fName,
                    String lName,DateTime birthDate, String contactNum,String email)
                    :base(fName,lName,birthDate,contactNum,email){
                        this.rollNo=rollNo;
                        this.registrationDate=registrationDate;
                        this.course=course;
                        count++;
                    }
    
    public override String ToString()
    {
        String data=base.ToString();
        return data+" "+this.rollNo+" "+this.registrationDate+" "+this.course;
    }
}
