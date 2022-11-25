namespace TFL;
using System;
using System.Collections;

public class Shipper: ICloneable {  
    
    public int id;  
    public string name;  
    
    public Shipper() {
        this.id=12;
        this.name="Surya Couriers";
    }
    public Shipper(int id, String name){  
        this.id = id;  
        this.name = name;  
    } 

    public  object Clone() { 
        //Logic for creating replica of same object as another new object
        
       Shipper temp=new Shipper();
       temp.id=this.id;
       temp.name=this.name;
       //temp is pointing to newly created and 
       //data copied object using clonning technique
       return temp;
    }  

    public override string ToString(){
        return "Id="+id+ " "+ "Name="+name;
    }
}