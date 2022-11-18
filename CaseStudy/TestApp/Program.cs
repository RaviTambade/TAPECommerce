// See https://aka.ms/new-console-template for more information

//Common Test

/*using Common;
using Catalog;
using System.Collections.Generic;

//using existing namespaces available for storing objects into json file
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

string fileName="people.json";
// Testing Person in Main
List<Person> people=Manager.Initialize();
Manager.Store(people,fileName);
List<Person> allRetrivedPeople=Manager.Restore(fileName);
Manager.Display(allRetrivedPeople);


// Testing Account in Main


// Testing Customer in Main



*/
//Banking Test
using CRM;
using Banking;
using Catalog;
using Delivery;
using BusinessProcessing;

/*List<Account> allAccounts=AccountManger.GetAll();*/
/*Account acct1=new Account{
    Id="565",
    Holder="Chandrakant Patil",
    Balance=67000
};

Account acct2=new Account{
    Id="589",
    Holder="Shivkaumar Kulkarni",
    Balance=67600
};

//AccountManger.Insert(acct1);
//AccountManger.Insert(acct2);

List<Account> latestAccounts=AccountManger.GetAll();
Console.WriteLine(" All Accounts from json file....");

/*foreach( Account acct in latestAccounts){

    Console.WriteLine("{0}  {1}  {2}", acct.Id, acct.Holder, acct.Balance);
}
*/

/*Account acct=AccountManger.GetById("589");
Console.WriteLine("{0}  {1}  {2}", acct.Id, acct.Holder, acct.Balance);

Console.WriteLine("Thank you so much for using our services.");
Console.WriteLine ("Updated output");


*/





   Order ord1=new Order{
             Id=27,
             Date=new DateTime(2022,12,11),
             TotalAmount=20000,
             Status="received",
     
          
};
          OrderManager.Insert(ord1);   

        Order ord2=new Order{
              Id=24,
             Date=new DateTime(2022,08,04),
             TotalAmount=78000,
             Status="processing",
           
             };


             OrderManager.Insert(ord2);


             Order ord3=new Order{
              Id=24,
             Date=new DateTime(2022,04,01),
             TotalAmount=7800,
             Status="processing",
           
             };


             OrderManager.Insert(ord3);



             List<Order> order=new List<Order>();
             order.Add(ord1);
             order.Add(ord2);
             order.Add(ord3);

             


        List<Order> theOrder=OrderManager.GetAll();
        Console.WriteLine("All order from json file.....");
       

       Order ord=OrderManager.GetById(24);
       Console.WriteLine("{0} {1} {2} {3} {4}",ord.Id,ord.Date,ord.TotalAmount,ord.Status,ord.Items);     


        //my commit





List <Customer> latestCustomer=CustomerManager.GetAll();
Console.WriteLine("All Customers from Json File...");

Customer cst1=new Customer
{
    Id="101",
    FirstName="seeta",
    LastName="shinde",
    ContactNumber="9883764521",
    Email="seeta.shinde@gmail.com",
};

CustomerManager.Insert(cst1);

Customer cst2=new Customer
{
    Id="102",
    FirstName="Geeta",
    LastName="Jadhav",
    ContactNumber="9883466523",
    Email="geeta.jadhav@gmail.com",
};
CustomerManager.Insert(cst2);

List <Customer> latestCustomers=CustomerManager.GetAll();
Console.WriteLine("All Customers from Json File...");
foreach(Customer cst in latestCustomers){
Console.WriteLine("{0} {1} {2} {3} {4}",cst.Id, cst.FirstName, cst.LastName, cst.ContactNumber, cst.Email);

}

//commited by nutan navale



//Delivery Manager Program.cs file---



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

// Account manager test code  by sahil

//Account code

//using Banking;

//creting object of Account class

Account two=new Account("2","Abhay",10000);
Account three=new Account("3","Shubhm",20000);
Account five =new Account("5","Roshan",25000);




List<Account> accounts=new List<Account>();
//accounts.Add(one);
accounts.Add(two);
accounts.Add(three);
accounts.Insert(0,five);  //built in List.insert method 
                          // here 0 is index number
                          // it will store as first item in file
   
   //accounts.Insert(2,new Account("4","Kunal",20000));  



string fileName="accounts.json";
// Testing Account in Main
AccountManger.Store(fileName,accounts);
List<Account> allRetrivedAccounts= AccountManger.Restore(fileName);
AccountManger.Display(allRetrivedAccounts); 

 Account one=new Account("1","sahil",5000);

 AccountManger.Insert(one);  //Here inserted one named object in file 
 AccountManger.Display(allRetrivedAccounts);


 two.Holder="prakash";   //if we update values like this we need to use update function of class
 two.Balance=12000;     //only then it will update inside file

AccountManger.Update( two); 

//another way is 
//AccountManger.Update(new ("2","prakash",12000));

AccountManger.Display(allRetrivedAccounts);

//AccountManger.Delete("1");  


Console.WriteLine( AccountManger.GetById("1")); // It will print ID=1  object


