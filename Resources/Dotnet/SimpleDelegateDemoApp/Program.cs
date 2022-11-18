//Function Pointer
    //ISR : Interrupt Service Routine
    //IVT : Interrupt Vector Table

    //What do you mean by Delegate:
    // It a object oriented  managed typsafe function Pointer
    // it a .net object wrapper for function Pointer



  //Rules for defininf delegate:
    // 1.return type is common
    // 2.input type is also common
    // 3.signature input and output variable types are common

    using SimpleDelegateDemoApp;

 

    double amount = 5000;


    //address of the function will be resolved at compile time
    //Direct Call
        //payIncomeTax(amount);  //Static linking, early binding, compile binding
    
    //late binding, Dynamic linking, runtime binding

    //Address of function will be resolved at runtime

    //Register address of methods with Delegate instances
    //Callback function Mapping
    //Dispatcher registration with callback function

    //Boilar plate Code
    TaxHandler handler = new TaxHandler(Controller.PayIncomeTax);
    dispatcher emailDispatcher = new dispatcher(Controller.SendEmail);
    dispatcher smsDispatcher = new dispatcher(Controller.SendSMS);

    //handler object acting like Proxy
    //Substitute, agent, broker,
    //Indirect Call
    
    //Invoke Delegate instances

    //Flow of your application
    //process of your application

    handler.Invoke(amount);
    
    emailDispatcher.Invoke("ravi.tambade@transflower.in", "Hi Ravi");
    smsDispatcher.Invoke("9881735801", "Hi Ravi this imp. message");