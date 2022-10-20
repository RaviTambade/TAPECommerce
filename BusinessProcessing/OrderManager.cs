using System.Collections.Generic;
using System.Text.Json;
using Catalog;


namespace BusinessProcessing
{
 
public class OrderManager
{
    public static bool Store(string fileName,List<Order> orders){
        string jsonString = JsonSerializer.Serialize(orders);
        Console.WriteLine(jsonString);
        File.WriteAllText(fileName,jsonString);
        return true;
    }
    public static List<Order> ReStore(string fileName)
    {
        string restoredJsonString=File.ReadAllText(fileName);
        //DeSerialization:Converting stream into objects
        List<Order> restoredOrders=JsonSerializer.Deserialize <List<Order>>(restoredJsonString);
        return restoredOrders;
    }
    public static bool Insert(Order orders){
    //Inset into Orders inside collection
        List<Order> allOrders=ReStore("orders.json");
        allOrders.Add(orders);
        bool status=Store("orders.json", allOrders);
        return status;
    }
    public static bool Update(Order orders){
    bool status=false;
     List<Order> allOrders=ReStore("orders.json");

    foreach( Order theOrder in allOrders){
        if(theOrder.Id == orders.Id){
           theOrder.Date=orders.Date;
           theOrder.TotalAmount=orders.TotalAmount;
           theOrder.Status=orders.Status;
           theOrder.Items=orders.Items;
            Store("orders.json",allOrders);
            status=true;
        }
     }
    return status;
    }

    public static List<Order> GetAll(){
        //Get All Order list from collection
        List<Order> allOrders=ReStore("orders.json");
        return allOrders;
    }

    public static Order GetById(int id){
        //Get Order object from collection whose id is match with input parameter
        List<Order> allOrders=ReStore("orders.json");
        Order foundOrder=null;
        foreach( Order theOrder in allOrders )
        {
            if(theOrder.Id == id){
                foundOrder=theOrder;
            }
            else{
                foundOrder=null;
            }
        }
         return foundOrder;
    }

    public static bool Delete(int ordId){
        bool status=false;
        List<Order> allOrders=ReStore("orders.json");
        foreach( Order theOrder in allOrders ){
        if(theOrder.Id == ordId)
        
        {
            allOrders.Remove(theOrder);
            Store("orders.json",allOrders);
            status=true;
        }    
    }
    return  status;
    }
}
}       //my commit

