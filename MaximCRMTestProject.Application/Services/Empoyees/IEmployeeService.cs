using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees;

public interface IEmployeeService
{
    List<EmployeeResult> GetAll();
    EmployeeResult Get(EmployeeId id);
    EmployeeResult Register(string fullName, string position);
    EmployeeResult Update(EmployeeId Id, string fullName, string position);
    EmployeeResult Delete(EmployeeId id);
}