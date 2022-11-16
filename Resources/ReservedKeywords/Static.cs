// This example illustrates the use of constant data and readonly fields.
using System;
using System.Text;

public class MyMathClass
 {
    public static readonly double PI;
    static MyMathClass()
    { PI = 3.14; }
 }

 public class Program
 {
    static void Main(string [] args)
    {
        Console.WriteLine ("***** Fun with Const *****\n");
        Console.WriteLine ("The value of PI is: {0}", MyMathClass.PI);
        // Error! Can't change a constant!
        // MyMathClass.PI = 3.1444;
        LocalConstStringVariable ();
    }
    static void LocalConstStringVariable()
    {
        // A local constant data point.
        const string fixedStr = "Fixed string Data";
        Console.WriteLine(fixedStr);
        // Error!
        //fixedStr = "This will not work!";
    }
 }

