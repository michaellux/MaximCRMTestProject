using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public List<EmployeeResult> GetAll()
    {
        return new List<EmployeeResult>();
    }

    public EmployeeResult Get(EmployeeId id)
    {
        throw new NotImplementedException();
    }

    public EmployeeResult Register(string fullName, string position)
    {
        // 1. Validate the employee doesn't exist
        if (_employeeRepository.GetEmployeeByFullName(fullName) is not null)
        {
            throw new Exception("Пользователь с таким ФИО уже существует.");
        }

        // 2. Create employee (generate unique ID) & persist to DB
        EmployeeId employeeId = new EmployeeId(Guid.NewGuid());
        var employee = new Employee(employeeId, fullName, position);

        _employeeRepository.Add(employee);


        return new EmployeeResult(employeeId, fullName, position);
    }

    public EmployeeResult Update(EmployeeId Id, string fullName, string position)
    {
        throw new NotImplementedException();
    }

    public EmployeeResult Delete(EmployeeId id)
    {
        throw new NotImplementedException();
    }
}