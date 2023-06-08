using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Common.Interfaces.Persistence
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetEmployeeByIdAsync(EmployeeId id);
        Task<Employee?> GetEmployeeByFullName(string fullName);
        Task<Employee> Add(Employee employee);
        void Update(Employee employee);
        void Remove(Employee employee);
    }
}
