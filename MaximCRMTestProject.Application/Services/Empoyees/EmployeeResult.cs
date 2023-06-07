namespace MaximCRMTestProject.Application.Services.Employees;

public record EmployeeResult(
  Guid id,
  string FullName,
  string Position
);