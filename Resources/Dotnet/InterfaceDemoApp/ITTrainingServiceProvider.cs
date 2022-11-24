namespace Training;


//Provider classes always impelment interface

public class ITTrainingServiceProvider : TrainingInterface
{
    public void Evaluate()
    {
        Console.WriteLine(" Candidate have been evaluated against Computer Science");
    }

    public void Teach()
    {
        Console.WriteLine(" Candidate have been taught Computer Science Subjects");
    }

    public void ConductPractical(){
         Console.WriteLine("conducting java, .net, mysql, react practical");

    }
}