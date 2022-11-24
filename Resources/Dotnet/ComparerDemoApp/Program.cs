using TFLCollections;
using System.Collections.Generic;

List<Employee> employees = new List<Employee>();

employees.Add(new Employee(1, "Raghu",30000));
employees.Add(new Employee(2, "Rajendra",67000));
employees.Add(new Employee(4, "Sham",20000));

Console.WriteLine("List of Employees before Sort");
foreach(Employee emp in employees){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}

EmpComparer ec = new EmpComparer();
employees.Sort(ec);

Console.WriteLine("List of Employees after Sort");
foreach(Employee emp in employees){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}