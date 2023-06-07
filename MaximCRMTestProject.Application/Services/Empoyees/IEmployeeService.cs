namespace MaximCRMTestProject.Application.Services.Employees;

public interface IEmployeeService
{
    List<EmployeeResult> GetAll();
    EmployeeResult Get(Guid id);
    EmployeeResult Add(string fullName, string position);
    EmployeeResult Update(Guid Id, string fullName, string position);
    EmployeeResult Delete(Guid id);
}