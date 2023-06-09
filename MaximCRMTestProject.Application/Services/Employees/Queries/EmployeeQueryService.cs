using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Application.Services.Employees.Queries;
using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees.Commands
{
    public class EmployeeQueryService : IEmployeeQueryService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeQueryService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> GetEmployee(EmployeeId id)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(id);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(id);
            }

            return new EmployeeResult(employee.Id, employee.FullName, employee.Position);
        }


    }
}
