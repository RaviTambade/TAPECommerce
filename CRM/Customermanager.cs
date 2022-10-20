using System.Collections.Generic;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
using Common;
namespace CRM;

public class CustomerManager
{

    public static List<Customer> Initialize(){
     Customer c1=new Customer{ CustomerId="m101",   FirstName="Akshay", LastName="Tanpure",   ContactNumber="658952166",Email="tanpure@gmail.com" };
     Customer c2=new Customer{  CustomerId="m102" ,  FirstName="Rajesh", LastName="Bhosale",  ContactNumber="5564198",Email="bhosale@gmail.com"};
     Customer c3=new Customer{   CustomerId="m103" ,   FirstName="Rohit", LastName="Patil",    ContactNumber="42867276",Email="patil@gmail.com"    };
     Customer c4=new Customer{    CustomerId="m104" ,   FirstName="Yash",   LastName="Maske",   ContactNumber="77686424",Email="yash.maske@gmail.com"};

     List<Customer>customer=new List<Customer>();
     customer.Add(c1);
     customer.Add(c2);
     customer.Add(c3);
     customer.Add(c4);
     return customer;
        
    }
  List<Customer>customers=new List<Customer>();
    public static bool Store( string fileName,List<Customer> customers){
        string jsonString=JsonSerializer.Serialize(customers);
        Console.WriteLine(jsonString);
        File.WriteAllText(fileName,jsonString);
        return true;
    }
   public static List<Customer> ReStore(string fileName){
      string RestoredJsonString=File.ReadAllText(fileName);
      List<Customer> restoredcustomers= JsonSerializer.Deserialize <List<Customer>>(RestoredJsonString);
      return restoredcustomers;
    }

    public static bool Insert(Customer customer){
        
    
        List<Customer> allCustomers=ReStore("customers.json");
        allCustomers.Add(customer);
        bool status=Store("customers.json",allCustomers);
        return status;

    }

    public static bool Update(Customer customer){
     
     bool status=false;
     List<Customer> allCustomers=ReStore("customers.json");
     foreach(Customer theCustomer in allCustomers)
     {
          if(theCustomer.CustomerId == customer.CustomerId )
          {
             theCustomer.FirstName=customer.FirstName;
             theCustomer.LastName=customer.LastName;
             theCustomer.ContactNumber=customer.ContactNumber;
             theCustomer.Email=customer.Email;
             Store("customers.json",allCustomers);
             status=true;
          }

     } 
     return status;  

    }

    public static List<Customer> GetAll(){
        
    
          List<Customer> allcustomers=ReStore("customers.json");
         return allcustomers;
    }

    public static Customer GetById(string id){
        
        List<Customer> allCustomers=ReStore("customers.json");
        Customer foundCustomer=null;
        foreach(Customer theCustomer in allCustomers){
         if (theCustomer.CustomerId==id)
         {
            foundCustomer=theCustomer;
         }
         else
         {
            foundCustomer=null;
         }
         
        }
        return foundCustomer;

    }

    
    public static bool Delete(string customerId)
    {
        bool status=false;
        List<Customer> allCustomers=ReStore("customers.json");
        foreach(Customer theCustomer in allCustomers){
         if (theCustomer.CustomerId==customerId)
            {
              allCustomers.Remove(theCustomer);
              Store("customers.json",allCustomers);
              status=true;

            }
        }
        return status;
    }
}