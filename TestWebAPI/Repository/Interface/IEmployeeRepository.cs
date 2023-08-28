using TestWebAPI.Model;

namespace TestWebAPI.Repository.Interface
{
    public interface IEmployeeRepository
    {

        void Add(Employee employee);

        List<Employee> Get();
    }
}
