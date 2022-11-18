using Common;
using System.Collections.Generic;
using System.Text.Json;
public class PeopleManager
{
    public static List<Person> Initialize() {
        //Property Initializer syntax
        //reference always stores address of an object created on heap of running application (process)
        //references are alwasy pushed to Stack memory of running application (process)
        Person prn1=new Person { FirstName="Sameer", LastName="Shinde", ContactNumber="9883765495",Email="sameer.shinde@gmail.com"};
        Person prn2=new Person { FirstName="Manisha", LastName="Jadhav", ContactNumber="9883465890",Email="manisha.jadhav@gmail.com"};
        Person prn3=new Person { FirstName="Sangita", LastName="More", ContactNumber="98834785695",Email="sangita.more@gmail.com"};
        Person prn4=new Person { FirstName="Rajiv", LastName="Nene", ContactNumber="9883465765",Email="rajiv.nen@gmail.com"};

        List<Person> people=new List<Person>();
        people.Add(prn1);
        people.Add(prn2);
        people.Add(prn3);
        people.Add(prn4);
        return people;
    }
    public static bool Store(string fileName, List<Person> people){
        // Differnt file formats: json, xml, txt, csv, etc.
        //convert data in json format
        // static method: method which called using class name
        // without creating object
        //Serialization :Converting objects into stream
        string jsonString = JsonSerializer.Serialize(people);
        Console.WriteLine(jsonString);
        File.WriteAllText(fileName, jsonString);
        return true;
    }
    public static List<Person> Restore(string fileName)
    {
        string restoredJsonString=File.ReadAllText(fileName);
        //DeSerialization:Converting stream into objects
        List<Person> restoredPeople=JsonSerializer.Deserialize <List<Person>>(restoredJsonString);
        return restoredPeople;
    }
    public static  void Display( List<Person> restoredPeople)
    {
        Console.WriteLine("Showing Restored  people from File people.json file");
        foreach( Person p in restoredPeople)
        {
            Console.WriteLine("{0}  {1}  {2} ", p.FirstName, p.LastName, p.ContactNumber);
        }
    }
}
//This programm is very hard to learn