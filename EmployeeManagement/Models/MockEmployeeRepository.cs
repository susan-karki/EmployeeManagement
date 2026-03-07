namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
                {
                     new Employee { Id = 1, Name = "John Doe", Email = "john@example.com", Department = Dept.IT },
                     new Employee { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Department = Dept.HR },
                     new Employee { Id = 3, Name = "Alice Johnson", Email = "alice@example.com", Department = Dept.Finance },
                };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
