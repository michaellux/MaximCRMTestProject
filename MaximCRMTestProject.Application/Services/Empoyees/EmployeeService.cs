namespace MaximCRMTestProject.Application.Services.Employees;

public class EmployeeService : IEmployeeService
{
    public List<EmployeeResult> GetAll()
    {
        return new List<EmployeeResult>();
    }

    public EmployeeResult Get(Guid id)
    {
        throw new NotImplementedException();
    }

    public EmployeeResult Add(string fullName, string position)
    {
        return new EmployeeResult(Guid.NewGuid(), fullName, position);
    }

    public EmployeeResult Update(Guid Id, string fullName, string position)
    {
        throw new NotImplementedException();
    }

    public EmployeeResult Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}