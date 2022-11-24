using Training;
using System.Collections.Generic;


//TrainingInterface cdac=new TrainingInterface();   //this is wrong 
/*Console.WriteLine( "\nITTrainingService Provider Instances");

TrainingInterface transflower=new ITTrainingServiceProvider();

Console.WriteLine( "transflower instance method invocation");
transflower.Teach();
transflower.ConductPractical();
transflower.Evaluate();

TrainingInterface qSpider=new ITTrainingServiceProvider();
Console.WriteLine( "\nqSpider instance mathod invocation");
qSpider.Teach();
qSpider.ConductPractical();
qSpider.Evaluate();

Console.WriteLine( "\nCoreScienceTrainingServiceProvider Instances");
TrainingInterface awateCollege=new CoreScienceTrainingServiceProvider();
Console.WriteLine( "\nawte College  instance mathod invocation");

awateCollege.Teach();
awateCollege.ConductPractical();
awateCollege.Evaluate();

TrainingInterface rajgurNagarCollege=new CoreScienceTrainingServiceProvider();
Console.WriteLine( "\n rajgurNagarCollege College  instance mathod invocation");
//All methods are getting called using interface variable
//But all interface variables are poining to concrete class instances
//This is called polymorphism

rajgurNagarCollege.Teach();
rajgurNagarCollege.ConductPractical();
rajgurNagarCollege.Evaluate();

*/



//This example using collection and interface we are solving 
//College administration problem
//empty list created

//container
List<TrainingInterface> institutes=new List<TrainingInterface>();

//Created individual instances 
TrainingInterface qSpider=new ITTrainingServiceProvider();
TrainingInterface transflower=new ITTrainingServiceProvider();

TrainingInterface rajgurNagarCollege=new CoreScienceTrainingServiceProvider();
TrainingInterface awateCollege=new CoreScienceTrainingServiceProvider();

TrainingInterface itiPune= new AutomobileTrainingServiceProvider();
TrainingInterface  itiNarayangoan= new AutomobileTrainingServiceProvider();

//added different objects in list
institutes.Add(transflower);
institutes.Add(qSpider);
institutes.Add(awateCollege);
institutes.Add(rajgurNagarCollege);
institutes.Add(itiPune);
institutes.Add(itiNarayangoan);

foreach( TrainingInterface institute in institutes){
   Console.WriteLine("\nTraining provider method invocation");
    institute.Teach();
    institute.ConductPractical();
    institute.Evaluate();
}


