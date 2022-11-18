// using System.Collections.Generic;
// using System.IO;
// using System.Text.Json;
// using System;
// using Delivery;

// public class DeliveryManager
// {

// public static bool Store (string fileName,List<Consignment> consignment)
// {
//   string jsonString =JsonSerializer.Serialize(consignment);
//   Console.WriteLine(jsonString);
//   File.WriteAllText(fileName,jsonString);
//   return true;
// }
// public static List<Consignment>ReStore(string fileName)
// {
//    string restoredJsonString=File.ReadAllText(fileName);

//    List<Consignment>restoredconsignments=JsonSerializer.Deserialize<List<Consignment>>(restoredJsonString);
//    return restoredconsignments;
// }
// public static bool Insert (Consignment consignment)
// {
//  List <Consignment> allConsignments= ReStore("consignments.json");
//  allConsignments.Add(consignment);
//  bool status =Store("consignments.json",allConsignments);
//  return status;
// }
// public static bool Update (Consignment consignment)
// {
//   bool status=false;

//   List<Consignment>allConsignments= ReStore("consignments.json");

//     foreach(Consignment theConsignment in allConsignments)
//         {
//            if (theConsignment.TransectionId== consignment.TransectionId)
//              {
//                theConsignment.Pickuplocation= consignment.Pickuplocation;
//                theConsignment.DeliveryAddress=consignment.DeliveryAddress;
//                Store("consignmets.json",allConsignments);
//                status=true;
//              }

    
//         }
//     return status;
// }
// public static List<Consignment> Getall()
// {
// List <Consignment>allConsignment=ReStore("consignments.json");
// return allConsignment;

// }

// public static Consignment GetByTransectionID(string TransectionId)
// {
//  List<Consignment> allConsignments=ReStore("consignments.json");
//  {
  
//   Consignment foundConsignment=null;
//   List<Consignment> allConsignments= ReStore("consignments.json");


// foreach(Consignment theConsignment in allConsignments)
// {
//  if (theConsignment.TransectionId == TransectionId)
//  {

//     foundConsignment=theConsignment ;

//  }
//  else
//  {

//   foundConsignment=null;

//  }

// }
// return foundConsignment;
//  }
//  }
// public static bool Delete(string TransectionId)
//     {
//         bool status=false;
//         List<Consignment> allConsignments=ReStore("Consignments.json");
//         foreach( Consignment theConsignment in allConsignments)
//         {
//         if(theConsignment.TransectionId==TransectionId)
//            {
//               allConsignments.Remove(theConsignment);
//               Store("consignment.json", allConsignments);
//               status=true;
//            }    
//         }
//     return  status;

//     }
// }

