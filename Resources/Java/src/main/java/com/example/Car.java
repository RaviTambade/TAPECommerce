 
package com.example;

public class Car  implements Comparable<Car>
    {
        public int year;
        public String make;
        public int milage;
       
        public Car(String make, int year, int m)
        {
            this.make = make;
            this.year = year;
            this.milage=m;
        }

        public int compareTo(Car obj)
        {
            Car secondCar = (Car)obj;
            if ( year > secondCar.year)
                return 1;

            if ( year < secondCar.year)
                return -1;

            else
                return 0;
        }
    }