
//import java.util.*;

package com.example;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Iterator;
import java.io.*;  

public class App 
{
    int real, imag;
   
    public App(){
        this.real=0;
        this.imag=0;
    }
   
    public App(int r, int i){
        this.real=r;
        this.imag=i;
    }

    @Override
    public String toString() {
        return this.real + " + " + this.imag + "i";
    }

    public static void main( String[] args )
    {
        App theApp=new App (34,45);
        System.out.println(theApp);
        System.out.println( "Hello World!" );

        Person thePerson=new Person("ravi","tambade", "ravi.tambade@transflower.in","5645801");
        System.out.println( thePerson);

       //Creating instance (object) from class
        //Two objects are created and their address are strored in
        //std1 and std2

        Student std1=new Student(12, "Sameer Kane", "BCS","sameer.k@gmail.com");
        Student std2=new Student(14, "Manisha Pant", "BE", "manisha.p@gmail.com");
        Student std3=new Student(15,"Kiran Mane","MCA");
        Student std4=new Student();

        //following WriteLine will automatically call ToString method for each object

        System.out.println(std1);
        System.out.println(std2);
        System.out.println(std3);
        System.out.println(std4);

        std1.ShowStatus();
        std2.ShowStatus();
        std3.ShowStatus();
        std4.ShowStatus();

        int noOfInstances=Student.GetCount();   //static or shared variable
        System.out.println("No of objects of Student class = "+ noOfInstances);


        /*Shape theShape=new Shape();
        Shape theShape2=new Shape("red");

        String obj1Color=theShape.GetColor();
        String obj2Color=theShape2.GetColor();
        
        System.out.println( "First object color="+ obj1Color);
        System.out.println( "Second object color= "+ obj2Color);
        */

        Line l1=new Line();
        System.out.println(l1.toString());
        
        Point pt1=new Point();
        pt1.setX(9);
        pt1.setY(18);
        
        Point pt2=new Point();
        pt2.setX(109);
        pt2.setY(88);

        System.out.println("Point object Writing....");
        System.out.println(pt2);

        Line l2=new Line(pt1,pt2,"green");
        System.out.println("Line object Writing....");
        System.out.println(l2);


        Employee mgr1=new Manager("Ram","Kapoor","ram.kapoor@gmail.com","9884576549",1,"marketing",3000,500,6000,2000,5000);
        Employee mgr2=new Manager("Seeta","Sharma","seeta.sharma@gmail.com","9884576456",2,"training",2000,600,8000,1000,5800);

        //Polymorphism is working 

        //even if you call method against parent class reference , still object is pointing to Derived Class

        double mgr1Salary=mgr1.ComputePay();
        double mgr2Salary=mgr2.ComputePay();

        System.out.println( "First Manager Salary ="+ mgr1Salary);
        System.out.println( "Second Manager Salary ="+ mgr2Salary);
        System.out.println("Terminating application");


        Shipper s = new Shipper(165, "Sarang Nene");  
        System.out.println(s.id + " " + s.name);  
        try {  
            Shipper s1 = (Shipper)s.clone();  
            System.out.println(s1.id + " " + s1.name);  
        }
        catch (Exception e) {   
            System.out.println(s.toString());  
        }  


        //Custom Exception Handling 
    /*     try  
        {    
            
            InvalidAgeEvaluator.validate (13) ;
        }  
        catch (InvalidAgeException ex)  
        {  
            System.out.println("Caught the exception");  
    
            // printing the message from InvalidAgeException object  
            System.out.println("Exception occured: " + ex);  
        }  
  
        System.out.println("rest of the code...");    
      
    */
        ArrayList<Car> cars=new ArrayList<Car>();  
        cars.add(new Car("Tata",2022,23));
        cars.add(new Car("Suzuki",2012,27));
        cars.add(new Car("Honda",2008,33));

  
        Collections.sort(cars);  
        for(Car st:cars){  
            System.out.println(st.make+" "+st.year + " "+ st.milage);  
        }  

        System.out.println("Sorting by Year");  
  
        Collections.sort(cars,new CarYearComparator());  
        Iterator<Car> itr=cars.iterator();  

        while(itr.hasNext()){  
            Car st=(Car)itr.next();  
            System.out.println(st.make+" "+st.year);  
        }  
        
        System.out.println("Sorting by milage");  
    
        Collections.sort(cars,new CarMilageComparator());  
         itr=cars.iterator();  

        while(itr.hasNext()){  
            Car st=(Car)itr.next();  
            System.out.println(st.make+" "+st.year + " "+ st.milage);  
        }  

        //Java Collection Framework

        ArrayList<String> list=new ArrayList<String>();//Creating arraylist    
        list.add("Gerbera");//Adding object in arraylist    
        list.add("Rose");    
        list.add("Lotus");    
        list.add("Jasmine");    
        //Printing the arraylist object   
        System.out.println(list);  

        //Traversing list through for-each loop  
        for(String flower:list)    
        System.out.println(flower);  


        //DAO Pattern
        BookDao bookDao = new BookDaoImpl();

        for (Book book : bookDao.getAllBooks()) {
            System.out.println("Book ISBN : " + book.getIsbn());
        }

        //update student
        Book book = bookDao.getAllBooks().get(1);
        book.setBookName("Algorithms");
        bookDao.saveBook(book);

       
        //Dependency Injection

        String msg = "Hi Pankaj";
		String email = "pankaj@abc.com";
		String phone = "4088888888";
		MessageServiceInjector injector = null;
		Consumer app = null;
		
		//Send email
		injector = new EmailServiceInjector();
		app = injector.getConsumer();
		app.processMessages(msg, email);
		
		//Send SMS
		injector = new SMSServiceInjector();
		app = injector.getConsumer();
		app.processMessages(msg, phone);

    }
}
