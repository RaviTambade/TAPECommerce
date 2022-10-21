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
using BusinessProcessing;

/*List<Account> allAccounts=AccountManger.GetAll();*/
Account acct1=new Account{
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

Account acct=AccountManger.GetById("589");
Console.WriteLine("{0}  {1}  {2}", acct.Id, acct.Holder, acct.Balance);

Console.WriteLine("Thank you so much for using our services.");
Console.WriteLine ("Updated output");








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