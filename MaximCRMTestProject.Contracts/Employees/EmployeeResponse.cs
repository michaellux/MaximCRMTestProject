namespace MaximCRMTestProject.Contracts.Employees;
public record EmployeeResponse(
  Guid id,
  string FullName,
  string Position
);