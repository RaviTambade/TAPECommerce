using Common;
namespace HR;
public class Employee:Person
{
     //Nullable type
        public int Id{get;set;}
        public double BasicSalary{get;set;}
        public double ProvidentFund{get;set;}
        public int  WorkingDays{get;set;}
        public double DailyAllowance{get;set;}
        public double RatePerHour{get;set;}


}
