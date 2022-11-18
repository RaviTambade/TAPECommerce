using Training;

//Creating instance (object) from class
//Two objects are created and their address are strored in
//std1 and std2

Student std1=new Student(12, "Sameer Kane", "BCS","sameer.k@gmail.com");
Student std2=new Student(14, "Manisha Pant", "BE", "manisha.p@gmail.com");
Student std3=new Student(15,"Kiran Mane","MCA");
Student std4=new Student();

//following WriteLine will automatically call ToString method for each object

Console.WriteLine(std1);
Console.WriteLine(std2);
Console.WriteLine(std3);
Console.WriteLine(std4);

std1.ShowStatus();
std2.ShowStatus();
std3.ShowStatus();
std4.ShowStatus();

int noOfInstances=Student.GetCount();   //static or shared variable
Console.WriteLine("No of objects of Student class = {0}", noOfInstances);


Console.WriteLine("Hello, World!");
