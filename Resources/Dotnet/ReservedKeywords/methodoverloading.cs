
//Method overloading

public class MathEngine
{
    public static double FindSquare (double number) {
         // logic defined 
    }
    public static double FindSquare (int number) {
         // another logic defined 
    }

    public static void Main ()
    {
        double res= MathEngine.FindSquare(12.5);
        double num= MathEngine.FindSquare(12);
    }
}
