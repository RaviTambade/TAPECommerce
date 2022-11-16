using ECommerce;
using HR;
using GDI;


Console.WriteLine("Hello, World!");
/**
*!There are two instances(object) are created of class Shape
*! theShape and theShape2 are called references to objects
*! in C# new keyword is used to create object of a class

*/


//int , float, double, short, char, string, boolean inbuilt types
/*
int marks=560;
Console.WriteLine(marks);

string fullName="Sachin Patil";
Console.WriteLine(fullName);


Shape theShape=new Shape();
Shape theShape2=new Shape("red");
string obj1Color=theShape.GetColor();
string obj2Color=theShape2.GetColor();
Console.WriteLine( "First object color= {0}", obj1Color);
Console.WriteLine( "Second object color= {0}", obj2Color);


Line l1=new Line();
Console.WriteLine(l1.ToString());

Point pt1=new Point();
pt1.X=9;
pt1.Y=18;

//Point, Line, Manager, Employee, Customer ,etc. These are user defined types
//means classes
Point pt2=new Point();
pt2.X=98;
pt2.Y=100;
Console.WriteLine("Point object Writing....");
Console.WriteLine(pt2);

Line l2=new Line(pt1,pt2,"green");
Console.WriteLine("Line object Writing....");
Console.WriteLine(l2);
*/


Employee mgr1=new Manager("Ram","Kapoor","ram.kapoor@gmail.com","9884576549",1,"marketing",3000,500,6000,2000,5000);
Employee mgr2=new Manager("Seeta","Sharma","seeta.sharma@gmail.com","9884576456",2,"training",2000,600,8000,1000,5800);

//Polymorphism is working 

//even if you call method against parent class reference , still object is pointing to Derived Class

double mgr1Salary=mgr1.ComputePay();
double mgr2Salary=mgr2.ComputePay();

Console.WriteLine( "First Manager Salary = {0}", mgr1Salary);
Console.WriteLine( "Second Manager Salary = {0}", mgr2Salary);
Console.WriteLine("Terminating application");


Console.WriteLine("Enter username:");

// Create a string variable and get user input from the keyboard and store it in the variable
string userName = Console.ReadLine();

// Print the value of the variable (userName), which will display the input value
Console.WriteLine("Username is: " + userName);


Console.WriteLine("Enter your age:");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Your age is: " + age);
