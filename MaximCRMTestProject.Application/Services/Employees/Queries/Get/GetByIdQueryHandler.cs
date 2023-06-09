using MaximCRMTestProject.Application.Common.Errors;
using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Queries.Get
{
    internal sealed class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, EmployeeResult>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetByIdQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeResult> Handle(GetByIdQuery query, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(query.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(query.EmployeeId);
            }

            return new EmployeeResult(employee.Id, employee.FullName, employee.Position);
        }
    }
}
