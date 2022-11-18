
namespace HR
{
    public class EmployeesController
    {
        private EmployeeService employeeService = null;
       
        //Constructor Dependency Injection
        //Dependency object is created and initialized during construction of 
        //EmployeeController object.

        public EmployeesController(EmployeeService svc)
        {
            employeeService = svc;
        }

        //Request Mapping Function
        public  List<Employee> Index()
        {
            return this.employeeService.GetAll();

        }
        public Employee Details(int id)
        {
            return this.employeeService.GetById(id);
        }

        public bool Post(Employee emp)
        {
            return   this.employeeService.Insert(emp);
        }


        public bool Put(Employee emp)
        {
            return this.employeeService.Update(emp);
        }

        public bool Delete(int id)
        {
            return this.employeeService.Delete(id);
        }
    }
}
