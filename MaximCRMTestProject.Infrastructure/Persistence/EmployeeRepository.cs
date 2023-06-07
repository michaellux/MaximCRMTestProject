using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Infrastructure.Persistence
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static readonly List<Employee> _employees = new();

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee? GetEmployeeByFullName(string fullName)
        {
            return _employees.SingleOrDefault(emp => emp.FullName == fullName);
        }

        public Task<Employee?> GetEmployeeById(EmployeeId id)
        {
            throw new NotImplementedException();
        }
    }
}
