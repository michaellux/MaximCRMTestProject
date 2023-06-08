using MaximCRMTestProject.Contracts.Employees;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Empoyees.Queries.GetEmployees
{
    public record GetQuery(EmployeeId EmployeeId) : IRequest
    {
    }
}
