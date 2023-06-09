using MaximCRMTestProject.Application.Services.Employees.Common;

namespace MaximCRMTestProject.Application.Services.Employees.Commands
{
    public interface IEmployeeCommandService
    {
        Task<EmployeeResult> Register(string fullName, string position);
    }
}
