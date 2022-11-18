using System.Collections.Generic;
using System.Text.Json;

namespace CRM;

public class CustomerManager
{

    public static List<Customer> Initialize(){
     Customer cst1=new Customer{ FirstName="Seeta", LastName="Shinde", ContactNumber="9883764521",Email="seeta.shinde@gmail.com",Id="101"};
     Customer cst2=new Customer{ FirstName="Geeta", LastName="Jadhav", ContactNumber="9883466523",Email="geeta.jadhav@gmail.com",Id="102"};
     Customer cst3=new Customer{ FirstName="Riya", LastName="More", ContactNumber="98834747896",Email="Riya.more@gmail.com",Id="103"};
     Customer cst4=new Customer{ FirstName="Siya", LastName="Nene", ContactNumber="9883123654",Email="Siya.nen@gmail.com",Id="104"};

     List<Customer> customers=new List<Customer>();
     customers.Add(cst1);
     customers.Add(cst2);
     customers.Add(cst3);
     customers.Add(cst4);
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
        
    //Inset into Account inside collection
        List<Customer> allCustomers=ReStore("customers.Json");
        allCustomers.Add(customer);
        bool status=Store("customers.Json",allCustomers);
        return status;

    }

    public static bool Update(Customer cst){
      //Update existing Customer from collection
     bool status=false;
     List<Customer> allCustomers=ReStore("customers.Json");
     foreach(Customer theCustomer in allCustomers)
     {
          if(theCustomer.Id== cst.Id )
          {
             theCustomer.FirstName=cst.FirstName;
             theCustomer.LastName=cst.LastName;
             theCustomer.ContactNumber=cst.ContactNumber;
             theCustomer.Email=cst.Email;
             Store("customers.Json",allCustomers);
             status=true;
          }

     } 
     return status;  

    }

    public static List<Customer> GetAll(){
        
        
         //Get All Customers list from collection
          List<Customer> allcustomers=ReStore("customers.Json");
         return allcustomers;
    }

    public static Customer GetById(string id){
         //Get Customer object from collection whose id is match with input parameter
        List<Customer> allCustomers=ReStore("customers.Json");
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
        List<Customer> allCustomers=ReStore("customers.Json");
        foreach(Customer theCustomer in allCustomers){
         if (theCustomer.Id==cstId)
            {
              allCustomers.Remove(theCustomer);
              Store("customers.Json",allCustomers);
              status=true;

            }
        }
        return status;
    }


}

//commited by Nutan Navale.