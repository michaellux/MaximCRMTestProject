using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Contracts.Employees;
public record UpdateEmployeeRequest(
  EmployeeId id,
  string FullName,
  string Position
);
