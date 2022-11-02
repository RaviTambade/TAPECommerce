using System;


namespace SimpleDelegateDemoApp
{
    //Hollywood Design Principle
    //Don't call me , I will call you.


    public delegate void TaxHandler(double amount);
    public delegate void dispatcher(string name, string body);

    internal class Controller
    {
        //set of helper functions
        //set of Callback functions
        //set of Action Handlers
        //set of event handlers
        //set of Action listeners
        //set of Hook function

        public static void PayIncomeTax(double amount)
        {
            Console.WriteLine("Income Tax has been automatically deducted from your Account : {0} Rs.", amount);
        }
        public static void PayTDS(double money)
        {
            Console.WriteLine("TDS has been automatically deducted from your Account : {0} Rs.", money);

        }
        public static void SendEmail(string email, string message)
        {
            Console.WriteLine("Email has been sent to respective person:{0},{1}",email,message);
        }
        public static void SendSMS(string contactNumber, string message)
        {
            Console.WriteLine("Email has been sent to respective person");
        }
    }
}
