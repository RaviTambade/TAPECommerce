package com.example;

public abstract class Shape {
    /**
    *!Data Member
    */
    protected String color; 
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

    /**
    *!getter and setter method will return or set value to private variable
    */
    public String GetColor(){
        return this.color;
    }

    public void SetColor(String c){
        this.color=c;
    }

    /**
     *!Destructor
     *!This function is automatically called during deIntializing object before
     *!destroying from heap memory
    */
    @Override  
    protected void finalize()   
    {   
        System.out.println("finalize method called");   
    }   
    
    //abstract method
    abstract void draw();  
}
