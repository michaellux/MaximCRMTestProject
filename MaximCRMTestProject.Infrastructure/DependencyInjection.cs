using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees;
using MaximCRMTestProject.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MaximCRMTestProject.Infrastructure;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure (this IServiceCollection services)
  {
    services.AddScoped<IEmployeeService, EmployeeService>();
    services.AddScoped<IEmployeeRepository, EmployeeRepository>();
    
    return services;
  }
}