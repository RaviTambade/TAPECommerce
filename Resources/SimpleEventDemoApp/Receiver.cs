
namespace Notifications
{
    public  class Receiver
    {
        //Event handlers or Event Receivers or Event Hook functions 
        public void BlockAccount()
        {
            Console.WriteLine("Your Account has been blocked temp..");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email has been sent to your registered Email Address");
        }

        public void SendSMS()
        {
            Console.WriteLine("Message has been sent to your registered Mobile Number");
        }
    }
}
