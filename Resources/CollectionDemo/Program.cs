 //Array syntax in CSharp Programming Languge
    using CollectionDemo;
    

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