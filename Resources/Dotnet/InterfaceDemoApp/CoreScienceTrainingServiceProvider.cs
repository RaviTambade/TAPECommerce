namespace Training;
public class CoreScienceTrainingServiceProvider:TrainingInterface
{

 public void Evaluate()
    {
        Console.WriteLine(" Candidate have been evaluated against physics, Chemistry, Biology");
    }

    public void Teach()
    {
        Console.WriteLine(" Candidate have been taught physics, Chemistry, Biology Subjects");
    }

    public void ConductPractical(){
         Console.WriteLine("conducting physics, Chemistry, Biology practical");
         
    }
}