using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Application.Services.Employees.Common;

public record EmployeeResult(
  EmployeeId Id,
  string FullName,
  string Position
);