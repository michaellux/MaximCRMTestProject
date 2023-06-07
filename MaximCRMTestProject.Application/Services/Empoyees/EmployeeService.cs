namespace MaximCRMTestProject.Application.Services.Employees;

public class EmployeeService : IEmployeeService
{
  public EmployeeResult Add(string fullName, string position)
  {
    return new EmployeeResult(Guid.NewGuid(), fullName, position);
  }
}