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
using Banking;

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