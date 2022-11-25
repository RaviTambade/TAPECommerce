



    using TFLTypes;
    namespace TFLTypes;
    public  delegate void BasicOperation();
    public  delegate void DoSomething();
    public  delegate int anonymousOperation1(int i); 
    public  delegate int anonymousOperation2(int a, int b);  

    public class Reporter{

        //Callback function
        public static void PrintReport(){
            Console.WriteLine("Printing a Report: graph, table, score card");
        }
    }