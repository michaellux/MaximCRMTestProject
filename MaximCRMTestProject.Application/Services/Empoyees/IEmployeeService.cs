namespace MaximCRMTestProject.Application.Services.Employees;

public interface IEmployeeService
{
    EmployeeResult Add(string fullName, string position);
}