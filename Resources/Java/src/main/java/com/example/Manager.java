package com.example;

/**
*!Three level Inheritance
*/

public class Manager extends Employee {
    private double bonus;
    private int stockOptions;

    public Manager(String fName, String lName, String email, String contact,int id, String dept,
                    double bSal, double da, double hra,
                    double bonus, int stocks){
        super(fName, lName, email, contact,id,  dept, bSal, da,  hra);
        this.bonus=bonus;
        this.stockOptions=stocks;
    }

    @Override  
    public  double ComputePay(){
        float profit  =0.7f;
        double salary=this.bonus + (stockOptions *profit  ) + super.ComputePay();
        return salary;
    }

    @Override  
    public  String toString()
    {
        String data= " " + this.bonus + " " + this.stockOptions ; 
        return  super.toString() + " " +data;
    }
}
