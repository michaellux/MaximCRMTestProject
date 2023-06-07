using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees;

public record EmployeeResult(
  EmployeeId Id,
  string FullName,
  string Position
);