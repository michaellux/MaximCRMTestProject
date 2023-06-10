using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Common.Interfaces.Persistence
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<Employee?> GetEmployeeByIdAsync(EmployeeId id);
        Task<Employee?> GetEmployeeByFullNameAsync(string fullName);
        Task<Employee> AddAsync(Employee employee);
        Task<Employee> UpdateAsync(Employee employee);
        Task<Employee> RemoveAsync(Employee employee);
    }
}
