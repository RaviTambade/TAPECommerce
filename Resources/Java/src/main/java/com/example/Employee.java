package com.example;

public class Employee extends Person {

    //data members
    protected int id;
    protected String department;
    protected double basicSalary;
    protected double hra;
    protected double da;

    public Employee(){

    }

    public Employee(String fName, String lName, String email,String contact,
                    int id, String dept, double hra, double bSal, double da)              
    {
        super(fName, lName, email,contact);
        this.id=id;
        this.department=dept;
        this.basicSalary=bSal;
        this.hra=hra;
        this.da=da;

    }

    //virtual keyword is always used first time for method 
    //that is to be overrided in their child classes
    public  double ComputePay(){
        //Logic for calculating salary
        double salary=this.basicSalary + this.hra+ (da *20);
        return salary;
    }

    @Override  
    public  String toString()
    {
        String data= " " + this.id + " " + this.department + " " +this.da + " "+  this.hra + " " +this.basicSalary ; 
        return  super.toString() + " " +data;
    }
}