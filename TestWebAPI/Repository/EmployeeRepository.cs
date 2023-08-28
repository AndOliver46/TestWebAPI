using TestWebAPI.Model;
using TestWebAPI.Repository.Interface;
using TestWebAPI.Util;

namespace TestWebAPI.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ConnectionUtil _connectionUtil = new ConnectionUtil();

        public void Add(Employee employee)
        {
            _connectionUtil.Employees.Add(employee);
            _connectionUtil.SaveChanges();
        }

        public List<Employee> Get()
        {
            return _connectionUtil.Employees.ToList();
        }
    }
}
