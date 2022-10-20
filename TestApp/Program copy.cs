// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//------------------product manager.cs file-------------------------------

/*

using Catalog;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using TestApp;

List<Product> allProducts = ProductManager.GetAll();


 {
 Product p1 =new Product()
    {  Id="101", Title="Mobile",PricePerProduct="20000", AvailableStock="25"};
    ProductManager.Insert(p1 );
 
 Product p2=new Product()
    { Id="102", Title="SmartTv", PricePerProduct="50000", AvailableStock="50"};
    ProductManager.Insert(p2);

 Product p3=new Product()
  { Id="103", Title="Laptop", PricePerProduct="75000", AvailableStock="25"};
    ProductManager.Insert(p3);
 Product p4=new Product()
   { Id="104", Title="SmartWatch", PricePerProduct="5000", AvailableStock="20"};
   ProductManager.Insert(p4);

    List<Product> products=new List<Product>();
      
        products.Add(p1);
        products.Add(p2);
        products.Add(p3);
        products.Add(p4);
      
List<Product> latestproduct=ProductManager.GetAll();

System.Console.WriteLine("All accounts from Json file");

foreach (Product product in latestproduct)
{
     System.Console.WriteLine("{0} {1} {2} {3}", product.Id, product.Title,product.PricePerProduct, product.AvailableStock);
    
}

}

 */ 
 

 // See https://aka.ms/new-console-template for more information
/*using Common;
using Catalog;
using System.Collections.Generic;

//using existing namespaces available for storing objects into json file
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

string fileName="people.json";
// Testing Person in Main
List<Acoount> people=Manager.Initialize();
Manager.Store(people,fileName);
List<Acoount> allRetrivedAccounts=Manager.Restore(fileName);
Manager.Display(allRetrivedAcoounts);


// Testing Account in Main


// Testing Customer in Main

*/

/*
using Banking;
using Catalog;
using Common;
using System.Collections.Generic;

list<Account> allAccounts = AccountManager.GetAll();
 Account acct1=new Account
 {
      Id="101",
      Holder="Vaibhav",
      Balance=50000
 };
 AccountManger.Insert(acct1);

 Account acct2=new Account
 {
      Id="102",
      Holder="Yash",
      Balance=75000
 };
 AccountManger.Insert(acct2);

List<Account> latestAccount=AccountManger.GetAll();
System.Console.WriteLine("All accounts from Json file");

foreach (Account acct in latestAccount)
{
     System.Console.WriteLine("{0} {1} {2}", acct.Id,acct.Holder,acct.Balance);
    
}



*/



//----------------Delivery Manager Program.cs file-------------------------------------
using Delivery;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

List<Consignment> allConsignments = DeliveryManager.Getall();
{
 Consignment c1=new Consignment
 {
      TransectionId="Mb202122",

      Pickuplocation="Pune",
 
      DeliveryAddress="Samatanagar Rajgurnagar",

      DeliveryStatus="not recived"

 };
 DeliveryManager.Insert(c1);

 Consignment c2=new Consignment
 {
      TransectionId="Mb202123",

      Pickuplocation="Mumbai",
 
      DeliveryAddress="Baner-BalewadiPune",

      DeliveryStatus="not recived"
 };
 DeliveryManager.Insert(c2);

List<Consignment> allconsignments=DeliveryManager.Getall();
System.Console.WriteLine("All Consignments from Json file");

foreach (Consignment consignment in allConsignments)
{
     System.Console.WriteLine("{0} {1} {2} {3}", consignment.TransectionId,consignment.Pickuplocation,consignment.DeliveryAddress, consignment.DeliveryStatus);
    
}
}




