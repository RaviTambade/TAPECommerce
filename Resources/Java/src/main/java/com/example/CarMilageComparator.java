package com.example;
import java.util.*; 

public class CarMilageComparator implements Comparator<Car>{  
    public int compare(Car c1,Car c2){  
        if(c1.milage==c2.milage)  
        return 0;  
        else if(c1.milage>c2.milage)  
        return 1;  
        else  
        return -1;  
    }  
}  