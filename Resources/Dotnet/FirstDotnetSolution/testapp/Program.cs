using CatalogLib;
using OrderProcessingLib;
using CRMLib;

//DOTNET CLI
//dotnet new console -o testapp

//Entry Point logic: Main function logic
int number=45;
number++;
Console.WriteLine("Number= "+ number);
Console.WriteLine("Hello, World!");

Product p1=new Product();
p1.Id=12;
p1.Title="Rose";
p1.Description="Valentine Flower";
p1.UnitPrice=25;
p1.StockAvailalbe=6000;
p1.ImageUrl="http://wordpress.com/ravitambade/logo.jpg";


Order o1=new Order();
o1.OrderId=45;
o1.OrderDate=new DateTime(2022,12,8);  // yyyy-mm-dd
o1.Customer="Microsoft";
o1.TotalAmount=670000;
o1.Status="approved";


Customer c1=new Customer();
c1.Id=564;
c1.FirstName="Salil";
c1.Lastname="Mankar";
c1.email="salil.mankar@gmail.com";
c1.ContactNumber="9886745376";

Console.WriteLine(c1.FirstName + " "+ c1.Lastname);
Console.WriteLine(p1.Title + " " + p1.Description + "  "+ p1.StockAvailalbe + "  "+p1.ImageUrl);
Console.WriteLine(o1.Customer + " " + o1.OrderDate + "  "+ o1.TotalAmount + o1.Status);