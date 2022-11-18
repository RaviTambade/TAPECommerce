
namespace TransflowerExceptions;

public class TutlaneCustomException: Exception
    {
       public TutlaneCustomException()
       {
       }
       public TutlaneCustomException(string message) : base(message)
       {
       }
       public TutlaneCustomException(string message, Exception innerexception) : base(message, innerexception)
       {
       }
}