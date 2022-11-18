package com.example;

public class Person {
    protected String firstName;
    protected String lastName;
    protected String email;
    protected String contactNumber;

    public Person(){
        this.firstName="Ravi";
        this.lastName="Tambade";
        this.email="ravi.tambade@transflower.in";
        this.contactNumber="9881735801";
    }

    public Person(String fName, String lName, String em, String contact){
        this.firstName=fName;
        this.lastName=lName;
        this.email=em;
        this.contactNumber=contact;
    }

    //Annotation
    @Override
    public   String toString()
    {
         String data=" "+ this.firstName +" " + this.lastName+ " " +this.email+ " " +this.contactNumber;
         return data;
    }
}
