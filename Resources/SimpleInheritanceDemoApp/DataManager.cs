using System.Collections.Generic;

namespace HR
{
    public class DataManager
    {
        private  List<Employee> employees = new List<Employee>();
        public Employee GetById(int id)
        {
            Employee emp = employees.Find(employee => (employee.EmpId == id));
            return emp;
        }
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public bool Update(Employee emp)
        {
            bool status = false;
            Employee foundEmployee= GetById(emp.EmpId);
            if (foundEmployee != null)
            {
                employees.Remove(foundEmployee);
                employees.Add(emp);
                status = true;
            }
            return status;
        }
        public bool Insert(Employee emp)
        {
            bool status = false;
            this.employees.Add(emp);
            status = true;
            return status;
        }
        public bool Delete(int id)
        {
            bool status = false;
            Employee foundEmployee = GetById(id);
            if (foundEmployee != null)
            {
                employees.Remove(foundEmployee);
                status = true;
            }
            return status;
        }
    }
}
