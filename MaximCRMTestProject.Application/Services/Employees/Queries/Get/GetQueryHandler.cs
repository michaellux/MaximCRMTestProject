using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees;
using MaximCRMTestProject.Contracts.Employees;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Empoyees.Queries.GetEmployees
{
    internal sealed class GetQueryHandler : IRequestHandler<GetQuery>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task Handle(GetQuery query, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepository.GetEmployeeByIdAsync(query.EmployeeId);

            if (employee is null)
            {
                throw new EmployeeNotFoundException(query.EmployeeId);
            }
        }
    }
}
