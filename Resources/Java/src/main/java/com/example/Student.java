package com.example;

public class Student {

    //it consist of data and functions
    //member variables (instance variables) 4
    private int id;
    private String fullName;
    private String qualification;
    private String email;

    //Function : consist of logic
    //Member functions 4
    // 3 overloded constructors
    //1  ToSTring method

    //static variables
    private static int count;

    //Getter and Setter methods
    public void setFullName(String name) {
        this.fullName=name;
    }

    public String  getFullName( ) {
       return this.fullName;
    }

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
        System.out.println("constructor is called....");
        count=count +1;
    }
    public Student(int i, String name, String education){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email="student.tfl@gmail.com";
        count=count+1;
    }
    public Student(int i, String name, String education, String em){
        this.id=i;
        this.fullName=name;
        this.qualification=education;
        this.email=em;
        count=count+1;
    }

    @Override
    public  String toString()
    {
        String data= " " + this.id + " " + this.fullName+ " "+ this.qualification + " "+ this.email;
        return data;
    }

    public void ShowStatus(){
        System.out.println("I am alive");
    }
    public static int GetCount(){
        return count;
    }
}
