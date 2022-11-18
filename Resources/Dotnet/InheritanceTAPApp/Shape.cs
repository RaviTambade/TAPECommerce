
namespace  GDI;
/**
*!Mother of all classes is Object class
*!ToString() method is inherited to classes because of Object parent class
*/
public class Shape
{
    /**
    *!Data Member
    */
    protected string color; 
    /**
    *!Member function
    *!Constructor
    *!It is the function which automatically get during initializing object
    *!default constructor
    *!This constcutor method does not take any input parameter
    */
    
    /**
    *!There are two member functions in class
    *!Constructor overloading
    */
    public Shape(){
        this.color="blue";
    }
    public Shape(string c){
        this.color=c;
    }

    /**
    *!getter and setter method will return or set value to private variable
    */
    public string GetColor(){
        return this.color;
    }

    public void SetColor(string c){
        this.color=c;
    }

    /**
     *!Destructor
     *!This function is automatically called during deIntializing object before
     *!destroying from heap memory
    */
    ~Shape(){

        Console.WriteLine( "DeInitializing instance.....");
    }
}