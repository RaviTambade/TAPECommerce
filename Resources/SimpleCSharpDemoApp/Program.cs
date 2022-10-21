
using CSFeaturesDemoApp;

 Console.WriteLine("CSharp Demo App");

    //instance.PI = 4.6;    // this is not allowed
    //instance.Name = "IET";

    //Annonymous Type
    // You can create object without Class
    var instance2 = new { FirstName="Ajeet" ,LastName="Kumar" };
    Console.WriteLine(instance2.FirstName +   " " + instance2.LastName);

    //You can create object without class name
    var flower = new
    {
        Id = 23,
        Title = "Gerbera",
        Description = "Wedding Flower",
        UnitPrice = 23,
        Quantity = 6000
    };


    int radius = 5;
    /*double area=CalculateArea(radius);
    Console.WriteLine(area);

    double circum=CalculateCircumference(radius);
    Console.WriteLine(circum);
    */

    double area = 0;
    double circum=0;

    Console.WriteLine("Before calling Calculate function");
    Console.WriteLine(area);
    Console.WriteLine(circum);

 
    Feature.Calculate(radius, out area, out circum); //out going parameter

    Console.WriteLine("After calling Calculate function");
    Console.WriteLine(area);
    Console.WriteLine(circum);

    Feature.PrintAll("Sunbeam",67);
    Feature.PrintAll("IET", "IACSD", "ACTS",45.7);
    Feature.PrintAll("seed", "transflower", true);

    int value1 = 67;
    int value2 = 100;
    Feature.Swap( ref value1, ref value2);
    Console.WriteLine(value1);
    Console.WriteLine(value2);


    //structure, int ,float, double, char, boolean:value type
        
    //value type instances are pushed on Stack
    //class, interface, delegate, event: refernce type
    //reference type instances are pushed on heap


    Student s1 = new Student();
    s1.BirthDate = new DateTime(1998, 3, 12);
    s1.Name = "Akshay Girmal";
    s1.Location = "Mumbai";
    s1.Id = 45;

    Student s2 = new Student();
    s2.BirthDate = new DateTime(1994, 3, 12);
    s2.Name = "Tejas Jawale";
    s2.Location = "Nashik";
    s2.Id = 44;


    int count = 56;  //value type
    object obj = count; //Boxing : converting value type to refernce type
    int count2 = (int)obj;  //UnBoxing: converting refernce  to value type



    //Array syntax in CSharp Programming Languge

    int [] numbers = { 23, 65, 87, 56, 45 };
    int[] marks = new int[5] { 76, 67, 78, 65, 45 };
    string[] trainers = { "Prachi", "Kishori", "Madhura", "Nilesh", "Amit" };

    //Arrays of object of type Student

    Student[] students = {
                            new Student{ BirthDate = new DateTime(1998, 3, 12),
                                            Name = "Akshay Girmal",
                                            Location = "Mumbai",
                                            Id = 45
                            },
                                new Student{ BirthDate = new DateTime(1992, 6, 22),
                                            Name = "Ramya Datta",
                                            Location = "Kolkatta",
                                            Id = 47
                            },
                                new Student{ BirthDate = new DateTime(1988, 3, 12),
                                            Name = "Manisha Patil",
                                            Location = "Pune",
                                            Id = 15
                            },

    };


    foreach( string name in trainers )
    {
        Console.WriteLine(name);
    }

    foreach ( Student s in students )
    {
        Console.WriteLine(s.Id + "  " + s.Name + "  " + s.Location);
    }



    Order order1=new Order();
    order1.Id = 876;
    order1.OrderDate = new DateTime(2022, 11, 7);
    order1.Customer = "IBM";
    order1.Status = "Onhold";

    Books books = new Books();
    books[0] = "Rich Dad Poor Dad";
    books[1] = "Wings of Fire";
    books[2] = "Who moved my Cheese";
    books[3] = "India Vision 2020";

    string bookTitle = books[1];
    Console.Write(bookTitle);
