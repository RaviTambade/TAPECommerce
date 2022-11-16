namespace HR;

/**
*!Three level Inheritance
*/
public class Manager:Employee{
    private double bonus;
    private int stockOptions;



public Manager(string fName, string lName, string email, string contact,
            int id, string dept,double bSal, double da, double hra,
             double bonus, int stocks):base(fName, lName, email, contact,
            id,  dept, bSal, da,  hra)

            //base keyword would call parent class parameterized constcutor
{
                this.bonus=bonus;
                this.stockOptions=stocks;
}
    public override double ComputePay(){
        float profit  =0.7f;
        double salary=this.bonus + (stockOptions *profit  ) + base.ComputePay();
        return salary;
    }

    public override string  ToString(){
        string data=string.Format("{0} ,{1}",bonus, stockOptions);
        return base.ToString() + " "+ data;
    }
}
