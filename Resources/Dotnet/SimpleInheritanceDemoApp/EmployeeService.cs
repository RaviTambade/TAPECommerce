namespace HR
{
    public class EmployeeService
    {
        DataManager dataManager = null;

        public EmployeeService(DataManager mgr)
        {
            dataManager = mgr;
        }

        public Employee GetById(int id)
        {
            return   dataManager.GetById(id);
        }

        public List<Employee> GetAll( )
        {
            return dataManager.GetAllEmployees();
        }

        public bool Insert(Employee emp)
        {
            return dataManager.Insert(emp);
        }

        public bool Update(Employee emp)
        {
            return dataManager.Update(emp);
        }

        public bool Delete (int id)
        {
            return dataManager.Delete(id);
        }
    }
}
