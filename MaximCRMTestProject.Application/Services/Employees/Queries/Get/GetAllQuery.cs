using MaximCRMTestProject.Application.Services.Employees.Common;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Queries.GetEmployees
{
    public record GeAllQuery() : IRequest<IEnumerable<EmployeeResult>>
    {
    }
}
