using BankingLogic;
using Notifications;
using GovtLib;



Account acct = new Account(50000);

Receiver receiver = new Receiver();
TaxManager txmgr = new TaxManager();


//Event Handler route mapping Logic
//Mapping event handler routes

//Attaching event with event handlers
//Registering event with event handlers


acct.underBalance += receiver.BlockAccount;
acct.underBalance += receiver.SendEmail;
acct.underBalance += receiver.SendSMS;

acct.overBalance += txmgr.DeductIncomeTax;
acct.overBalance += txmgr.DeductServiceTax;

//Account operations will be taken place
Console.WriteLine("Enter Amount to Withdraw");
double amount=double.Parse(Console.ReadLine());
acct.Withdraw(amount);
Console.WriteLine(acct.Balance);