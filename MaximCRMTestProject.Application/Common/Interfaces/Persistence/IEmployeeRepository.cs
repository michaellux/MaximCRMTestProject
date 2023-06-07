using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Common.Interfaces.Persistence
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetEmployeeById(EmployeeId id);
        Employee? GetEmployeeByFullName(string fullName);
        void Add(Employee employee);
    }
}
