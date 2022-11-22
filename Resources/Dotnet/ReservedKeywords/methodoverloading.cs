
//Method overloading

public class MathEngine
{
    public static double FindSquare (double number) {
         // logic defined 
         return 34D;
    }
    public static double FindSquare (int number) {
         // another logic defined 
         return 56D;
    }

    public static void Main ()
    {
        double res= MathEngine.FindSquare(12.5);
        double num= MathEngine.FindSquare(12);
    }
}
