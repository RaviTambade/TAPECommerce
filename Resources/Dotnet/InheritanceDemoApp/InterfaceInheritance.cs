using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceDemoApp
{
    public interface IDetails
    {
        void show();
    }

    //multilevel interface inheritance
    public interface ICustomerDetails:IDetails
    {
        void ShowCustomerProfile();
    }

    public interface IOrderDetails
    {
        void ShowOrderHistory();
        void Display();
       
    }

    public interface IPaymentDetails
    {
        void Display();

    }

    //Multiple Inhterface Inheritance
    public class CustomerDashBoard:ICustomerDetails,IOrderDetails,IPaymentDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }


        //Explicit Interface Inheritance
        //Fully Qualified Name to be assigned for method
        void IOrderDetails.Display()
        {
            Console.WriteLine("Showing Customer  Order Details Details");
        }

        void IPaymentDetails.Display()
        {
            Console.WriteLine("Showing Customer  Payment Details");
        }

        public void show()
        {
            Console.WriteLine("Customer Personal Information");
        }

        public void ShowCustomerProfile()
        {
            Console.WriteLine("Customer Profile Details Information");
        }

        public void ShowOrderHistory()
        {
            Console.WriteLine("Customer existing orders  Information");
        }
    }


    //Using inbuilt interface provided by .net
    //ICloneable interface
    //Deep Copy example

    public class Stack:ICloneable
    {
        int size;
        int[] sArr;

        public Stack(int size)
        {
            this.sArr = new int[size];
            for(int i = 0; i < size; i++)
            {
                this.sArr[i] = i+9;
            }
            this.size = this.sArr.Length;
        }

        public object Clone()
        {
            //Shallow Copy: only refernces are copied
            //Deep Copy:objects pointed by references are copied into new object

            Stack newCopyStack = new Stack(this.size);
            // newCopyStack.sArr = this.sArr;  //Shallow Copy
            this.sArr.CopyTo(newCopyStack.sArr, 0);
            return newCopyStack;
        }
    }
    
}
