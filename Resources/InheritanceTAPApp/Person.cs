namespace ECommerce;
public class Person
{
    //Data members
    protected string firstName;
    protected string lastName;
    protected string email;
    protected string contactNumber;

    //Member functions
    public Person(){
        this.firstName="Ravi";
        this.lastName="Tambade";
        this.email="ravi.tambade@transflower.in";
        this.contactNumber="9881735801";
    }

    public Person(string fName, string lName, string em, string contact){
        this.firstName=fName;
        this.lastName=lName;
        this.email=em;
        this.contactNumber=contact;
    }


    public override string ToString()
    {
         string data=string.Format( "{0} {1}  {2} {3} ", this.firstName , this.lastName, this.email, this.contactNumber);
         return data;
    }
}