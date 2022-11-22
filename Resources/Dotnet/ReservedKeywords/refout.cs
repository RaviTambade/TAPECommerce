
public class DemoClass {
    //method overloading
    //function overloading
    //pass by value
    public   static void  Swap ( int n1, int n2)
    {
        //swapping of values

            int temp =n1; 
            n1=n2;
            n2=temp;
            Console.WriteLine(  " n1 ="+ n1 + " n2= "+ n2);

    }

    //pass by address
    //pass by reference
    public  static void  Swap (ref int n1, ref int n2)
    {
        ///swapping of addresses (references)
            int temp =n1;
             n1=n2; 
             n2=temp;
    }
    
    public static void   Calculate (float radius, out float area, out float circum)
    {
        //out variables values are changed by function
        area=3.14f * radius * radius;
        circum=2*3.14f * radius;
    }
}