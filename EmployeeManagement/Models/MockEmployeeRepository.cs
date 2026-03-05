namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
                {
                     new Employee { Id = 1, Name = "John Doe", Email = "john@example.com", Department = "IT" },
                     new Employee { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Department = "HR" },
                     new Employee { Id = 3, Name = "Alice Johnson", Email = "alice@example.com", Department = "Finance" },
                };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
