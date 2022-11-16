
using ECommerce;
namespace HR;


/**
*!Two level Inheritance
*/
public class Employee:Person {

    //data members
    protected int id;
    protected string department;
    protected double basicSalary;
    protected double hra;
    protected double da;


    public Employee(){

    }
    public Employee(string fName, string lName, string email,string contact,
                    int id, string dept, double hra, double bSal, double da)
                    :base(fName, lName, email,contact)
    {
                        this.id=id;
                        this.department=dept;
                        this.basicSalary=bSal;
                        this.hra=hra;
                        this.da=da;

    }

    //virtual keyword is always used first time for method 
    //that is to be overrided in their child classes
    public virtual double ComputePay(){
        //Logic for calculating salary
        double salary=this.basicSalary + this.hra+ (da *20);
        return salary;
    }


    public override string ToString()
    {
        string data=string.Format("{0} ,{1}, {2}, {3}, {4}",
                            this.id,this.department, this.da, this.hra, this.basicSalary) ; 
       return  base.ToString() + " " +data;
    }
}