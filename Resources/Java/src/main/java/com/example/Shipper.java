package com.example;

public class Shipper implements Cloneable {  
    
    int id;  
    String name;  
    
    Shipper(int id, String name){  
        this.id = id;  
        this.name = name;  
    } 

    @Override  
    protected Object clone() throws CloneNotSupportedException {  
        return super.clone();  
    }  
}
