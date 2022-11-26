using HR;

static void Display(object o)
{
    Console.WriteLine(o.ToString());
}


Display(34);
Display("Transflower");
Display(4.453655);
Display(new Employee("Ravi", "Tambade"));

object obj = new Employee("Sachin", "Sharma");

//using Reflection 
Type instnaceType = obj.GetType();
Console.WriteLine("Instance Type = "+instnaceType.Name);

int hashCode=obj.GetHashCode();
Console.WriteLine("Hashcode of instance " + hashCode);