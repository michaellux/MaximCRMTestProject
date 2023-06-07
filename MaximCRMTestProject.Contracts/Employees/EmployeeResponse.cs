using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Contracts.Employees;
public record EmployeeResponse(
  EmployeeId id,
  string FullName,
  string Position
);