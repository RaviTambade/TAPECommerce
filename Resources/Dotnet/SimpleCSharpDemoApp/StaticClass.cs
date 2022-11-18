namespace CSFeaturesDemoApp
{
    public class Feature{


        const double PI = 3.14;// allows to keep constant ness  through out
        readonly string Name; // allows to variable initialized at the time construction.


       public static double  CalculateArea(int radius)
        {
            //area of circle
            double areaOfCirlcle = PI * radius * radius;
            return areaOfCirlcle;
        }

        public static double CalculateCircumference(int radius)
        {
            //area of circle
            double circumOfCirlcle = 2*PI * radius;
            return circumOfCirlcle;
        }

        public static void  Calculate (int radius, out double area,out double circum )
        {
            area = PI * radius * radius;
            circum = 2 * PI * radius;
        }

        public static void PrintAll(params object[] objects)
        {
            foreach (object o in objects)
            {
                Console.WriteLine(o);
            }
        }

        public static void Swap(ref int num1,ref  int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}