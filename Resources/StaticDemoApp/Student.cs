namespace Training;
public class Student{
    //it consist of data and functions
    //member variables (instance variables) 4
    private int id;
    private string fullName;
    private string qualification;
    private string email;

    //Function : consist of logic
    //Member functions 4
    // 3 overloded constructors
    //1  ToSTring method

    //static variables
    private static int count;
    //Constructor
    //default constructor

    //Constructor Overloading
    //name of function is same 
    //but their parameter will be different
    //each one will have differnt logic
    public Student(){
        //initialize data members
        this.id=45;
        this.fullName="Nutan Navale";
        this.qualification="BE";
        this.email="nutan.navale@gmail.com";
        Console.WriteLine("constructor is called....");
        count=count +1;
    }
    public Student(int i, string name, string education){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email="student.tfl@gmail.com";
        count=count+1;

    }
    public Student(int i, string name, string education, string em){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email=em;
        count=count+1;

    }

    public override string ToString()
    {
        string data=string.Format(" {0}, {1}, {2}",
                                this.id, this.fullName, this.qualification);
        return data;
    }


    public void ShowStatus(){
        Console.WriteLine("I am alive");
    }
    public static int GetCount(){
        return count;
    }
}