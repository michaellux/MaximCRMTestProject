using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Queries.Get
{
    internal sealed class GetAllQueryHandler : IRequestHandler<GeAllQuery, IEnumerable<EmployeeResult>>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetAllQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeResult>> Handle(GeAllQuery request, CancellationToken cancellationToken)
        {
            var employeesTask = _employeeRepository.GetAllEmployeesAsync();
            var result = await employeesTask.
                ContinueWith(task => task.Result.Select(employee => new EmployeeResult(employee.Id, employee.FullName, employee.Position)));
            return result;
        }
    }
}
