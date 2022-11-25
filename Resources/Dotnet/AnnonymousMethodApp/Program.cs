



        using TFLTypes;
        

  
        // register the function
        // registering callback function
        
        BasicOperation method1=new BasicOperation(Reporter.PrintReport);  
        //resolving name of fn at runtime
        method1();

        //Inline function
        //annonymous Method
        BasicOperation method2=delegate(){
            Console.WriteLine("Printing Company annual Reoprt");
        };

        method2(); 
          
        //lambda 
        DoSomething menthod3=()=>{Console.WriteLine("Printing COVID spread Lockdown  Reoprt");};
        menthod3();
        
        anonymousOperation1 proxy1 = new anonymousOperation1(delegate(int x){  return x * 2;  } );  
        Console.WriteLine("{0}", proxy1(5));  
        anonymousOperation1 proxy2=x=>x*2;  // use of lambda
        Console.WriteLine("{0}", proxy2(25));  

        //(input parameters) => Expression; 
        anonymousOperation2 getBigInteger = (x, y) => { if (x > y) return x; else return y; };  
        Console.WriteLine(getBigInteger(10,15));  

        // Which is the good language ?
        // Answer:The language which transforms itself over period as per 
        // the culture of society  transforms
        Console.WriteLine("Welcome to .NET Core Programming!");