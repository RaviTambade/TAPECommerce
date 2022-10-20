using System.Collections.Generic;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;
namespace CRM;

public class CustomerManager
{

    public static List<Customer> Initialize(){
     Customer c1=new Customer{ CusromerId="m101", FirstName="Akshay", LastName="Tanpure",   ContactNumber="658952166",Email="tanpure@gmail.com", Id="101"};
     Customer c2=new Customer{  CusromerId="m102" , FirstName="Rajesh", LastName="Bhosale",  ContactNumber="5564198",Email="bhosale@gmail.com",   Id="102"};
     Customer c3=new Customer{   CusromerId="m103" ,  FirstName="Rohit", LastName="Patil",    ContactNumber="42867276",Email="patil@gmail.com",     Id="103"};
     Customer c4=new Customer{    CusromerId="m104" ,  FirstName="Yash",   LastName="Maske",   ContactNumber="77686424",Email="yash.maske@gmail.com", Id="104"};

     List<Customer>customers=new List<Customer>();
     customers.Add(c1);
     customers.Add(c2);
     customers.Add(c3);
     customers.Add(c4);
     return customers;
        
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

    public static bool Update(Customer cst){
     
     bool status=false;
     List<Customer> allCustomers=ReStore("customers.json");
     foreach(Customer theCustomer in allCustomers)
     {
          if(theCustomer.Id== cst.Id )
          {
             theCustomer.FirstName=cst.FirstName;
             theCustomer.LastName=cst.LastName;
             theCustomer.ContactNumber=cst.ContactNumber;
             theCustomer.Email=cst.Email;
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
         if (theCustomer.Id==id)
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

    
    public static bool Delete(string cstId)
    {
        bool status=false;
        List<Customer> allCustomers=ReStore("customers.json");
        foreach(Customer theCustomer in allCustomers){
         if (theCustomer.Id==cstId)
            {
              allCustomers.Remove(theCustomer);
              Store("customers.json",allCustomers);
              status=true;

            }
        }
        return status;
    }


}