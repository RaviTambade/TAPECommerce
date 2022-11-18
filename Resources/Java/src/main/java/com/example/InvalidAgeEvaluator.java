package com.example;

public class InvalidAgeEvaluator {

    static void validate (int age) throws InvalidAgeException{    
        if(age < 18){  
            // throw an object of user defined exception  
            throw new InvalidAgeException("age is not valid to vote");    
            }  
        else {   
            System.out.println("welcome to vote");   
         }   
    }
}