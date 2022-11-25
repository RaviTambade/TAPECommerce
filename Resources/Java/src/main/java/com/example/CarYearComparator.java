package com.example;
import java.util.*; 

public class CarYearComparator implements Comparator<Car>{  

    public int compare(Car c1,Car c2){  
        if(c1.year==c2.year)  
        return 0;  
        else if(c1.year>c2.year)  
        return 1;  
        else  
        return -1;  
    }  
}  