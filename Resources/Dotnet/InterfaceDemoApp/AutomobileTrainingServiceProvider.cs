namespace Training;

public class AutomobileTrainingServiceProvider : TrainingInterface
{
    public void ConductPractical()
    {
        Console.WriteLine("conducting two strok, four strok engine practicals");
    }

    public void Evaluate()
    { 
      Console.WriteLine(" Candidate have been evaluated against Elements of Mechanical Engg.");
    }

    public void Teach()
    {
         Console.WriteLine(" Candidate have been taught SOM, TOM, Dynamics Subjects");
    }
}