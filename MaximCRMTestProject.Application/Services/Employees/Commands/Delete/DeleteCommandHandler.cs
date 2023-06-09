using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.DeleteEmployees
{
    internal sealed class DeleteCommandHandler : IRequestHandler<DeleteCommand, EmployeeResult>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DeleteCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(request.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(request.EmployeeId);
            }

            var result = await _employeeRepository.RemoveAsync(employee);
            return new EmployeeResult(result.Id, result.FullName, result.Position); 
        }
    }
}
