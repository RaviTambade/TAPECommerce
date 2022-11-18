package com.example;
import java.util.*; 

public class CarMilageComparator implements Comparator<Car>{  

    public int compare(Car o1,Car o2){  
        Car s1=(Car)o1;  
        Car s2=(Car)o2;  
        
        if(s1.milage==s2.milage)  
        return 0;  
        else if(s1.milage>s2.milage)  
        return 1;  
        else  
        return -1;  
    }  
}  