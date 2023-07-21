using STUD;
using HR;
using Complex;
using Drawing;
using System;
using SpecificationLib;
using ImplementationLib;

Console.WriteLine("Hello, World!");
Console.WriteLine("Iacsd");

Person p1=new Person();
p1.FName="Anish";

Console.WriteLine(p1.FName);

Person p2=new Person("Anish","Rachcha",new DateTime(2023,09,01),"9423749050","anishrachcha@gmail.com");
Console.WriteLine(p2);
//int rollNo,DateTime registrationDate,String course,String fName,
                 //   String lName,DateTime birthDate, String contactNum,String email
Student s=new Student(233012,new DateTime(2023,03,17),"DAC","Anish","Rachcha",new DateTime(2023,09,01),"9423749050","anishrachcha@gmail.com");
Console.WriteLine(s);

ComplexNumber c1=new ComplexNumber(5,12);

Console.WriteLine(c1);

Point point1=new Point(2,5);
Console.WriteLine(point1);
Point point2=new Point(7,65);
//Point p1,Point p2,int width,string color
Line l1=new Line(point1,point2,5,"red");
Console.WriteLine(l1);
//int id,string title,string description,double unitPrice,int quantity
ISellable prod1=new Product(101,"Lays","Crispy",20,6000);
prod1.test();
prod1.promote();
prod1.sell();




