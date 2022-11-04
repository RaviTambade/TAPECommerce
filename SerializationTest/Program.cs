// See https://aka.ms/new-console-template for more information
using System;
using Common;
using Delivery;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

Vendor theDelivery=new Vendor();

theDelivery.FirstName="Abhay";
theDelivery.LastName="Navale";
theDelivery.Email="abhay@gmail";
theDelivery.ContactNumber="9076897656";
theDelivery.Id="12";
theDelivery.Location="Manchar";


Vendor theDelivery1=new Vendor();

theDelivery1.FirstName="Shubham";
theDelivery1.LastName="Teli";
theDelivery1.Email="shubham@gmail";
theDelivery1.ContactNumber="9076897623";
theDelivery1.Id="13";
theDelivery1.Location="Khed";


List<Vendor> deliveries=new List<Vendor>();

deliveries.Add(theDelivery);
deliveries.Add(theDelivery1);

deliveries.Add(new Vendor{FirstName="Sahil",LastName="Mankar",Email="sahil@gmail",ContactNumber="98761234120",Id="44",Location="Prgaon"});
deliveries.Add(new Vendor{FirstName="abhi",LastName="Navale",Email="abhi@gmail",ContactNumber="98765567820",Id="11",Location="Thugaon"});
deliveries.Add(new Vendor{FirstName="jayesh",LastName="Mankar",Email="jayesh@gmail",ContactNumber="98762345120",Id="16",Location="Chas"});
deliveries.Add(new Vendor{FirstName="datta",LastName="kale",Email="datta@gmail",ContactNumber="98765434679",Id="178",Location="Peth"});

foreach(Vendor delivery in deliveries){
    Console.WriteLine("{0} {1} {2} {3} {4} {5}",delivery.FirstName,delivery.LastName,delivery.Email,delivery.ContactNumber,delivery.Id,delivery.Location);
}

try{
    Stream stream = new FileStream("deliveries.bin",FileMode.Create,FileAccess.Write,FileShare.None);
    BinaryFormatter formatter=new BinaryFormatter();
    formatter.Serialize(stream,deliveries);
    stream.Close();
    
}
catch(Exception exp){

}
finally{
    
}
//Logic for Deserialization
Console.WriteLine("After desearialization....");
try{
    BinaryFormatter formatter=new BinaryFormatter();
    Stream stream = new FileStream("deliveries.bin",FileMode.Open,FileAccess.Read,FileShare.Read);
    List<Vendor> deliveriesFromFile=(List<Vendor>)formatter.Deserialize(stream);
    foreach(Vendor delivery in deliveriesFromFile){
        Console.WriteLine("{0} {1} {2} {3} {4} {5}",delivery.FirstName,delivery.LastName,delivery.Email,delivery.ContactNumber,delivery.Id,delivery.Location);
    }
    stream.Close();
}
catch(Exception exp){

}
finally{

}