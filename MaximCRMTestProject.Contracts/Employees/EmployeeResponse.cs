using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Contracts.Employees;
public record EmployeeResponse(
  EmployeeId Id,
  string FullName,
  string Position
);