using MaximCRMTestProject.Application.Common.Errors;
using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.Update
{
    internal sealed class UpdateCommandHandler : IRequestHandler<UpdateCommand, EmployeeResult>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public UpdateCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> Handle(UpdateCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(request.EmployeeId);
            }

            var targetEmployeeWithName = await _employeeRepository.GetEmployeeByFullNameAsync(request.FullName);
            if (targetEmployeeWithName is null)
            {
                employee.Update(request.FullName, request.Position);
                var result = await _employeeRepository.UpdateAsync(employee);

                return new EmployeeResult(result.Id, result.FullName, result.Position);
            }
            else
            {
                throw new EmployeeWithSameFullNameException(employee.FullName);
            }
        }
    }
}
