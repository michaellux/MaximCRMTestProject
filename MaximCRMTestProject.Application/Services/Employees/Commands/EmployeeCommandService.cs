using MaximCRMTestProject.Application.Common.Errors;
using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees.Commands
{
    public class EmployeeCommandService : IEmployeeCommandService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeCommandService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> Register(string fullName, string position)
        {
            if (_employeeRepository.GetEmployeeByFullNameAsync(fullName) is not null)
            {
                throw new EmployeeWithSameFullNameException(fullName);
            }

            EmployeeId employeeId = new EmployeeId(Guid.NewGuid());
            var employee = new Employee(employeeId, fullName, position);

            var result = await _employeeRepository.AddAsync(employee);

            return new EmployeeResult(result.Id, result.FullName, result.Position);
        }
    }
}
