using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;
using Delivery;

public class DeliveryManager
{

public static bool Store (string fileName,List<Consignment> consignment)
{
  string jsonString =JsonSerializer.Serialize(consignment);
  Console.WriteLine(jsonString);
  File.WriteAllText(fileName,jsonString);
  return true;
}
public static List<Consignment>ReStore(string fileName)
{
   string restoredJsonString=File.ReadAllText(fileName);

   List<Consignment>restoredconsignments=JsonSerializer.Deserialize<List<Consignment>>(restoredJsonString);
   return restoredconsignments;
}
public static bool Insert (Consignment consignment)
{
 List <Consignment> AllConsignments= ReStore("consignments.json");
 AllConsignments.Add(consignment);
 bool status =Store("consignments.json",AllConsignments);
 return status;
}
public static bool Update (Consignment consignment)
{
  bool status=false;

  List<Consignment>AllConsignments= ReStore("consignment.json");

    foreach(Consignment TheConsignment in AllConsignments)
        {
           if (TheConsignment.TransectionId== consignment.TransectionId)
             {
               TheConsignment.Pickuplocation= consignment.Pickuplocation;
               TheConsignment.DeliveryAddress=consignment.DeliveryAddress;
               Store("Consignmet.json",AllConsignments);
               status=true;
             }

    
        }
    return status;
}
public static List<Consignment> Getall()
{
List <Consignment>AllConsignment=ReStore("Consignment.json");
return AllConsignment;

}

public static Consignment GetByTransectionID(string TransectionId)
{
 List<Consignment>AllConsignments=ReStore("Consignment.json");
 {
  
  Consignment foundConsignment=null;
  List<Consignment>allConsignments= ReStore("Consignments.json");


foreach(Consignment theConsignment in allConsignments)
{
 if (theConsignment.TransectionId == TransectionId)
 {

    foundConsignment=theConsignment ;

 }
 else
 {

  foundConsignment=null;

 }

}
return foundConsignment;
 }
 }
public static bool Delete(string TransectionId)
    {
        bool status=false;
        List<Consignment> allConsignments=ReStore("Consignments.json");
        foreach( Consignment theConsignment in allConsignments)
        {
        if(theConsignment.TransectionId==TransectionId)
           {
              allConsignments.Remove(theConsignment);
              Store("Consignment.json", allConsignments);
              status=true;
           }    
        }
    return  status;






}
}


