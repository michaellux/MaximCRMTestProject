using MaximCRMTestProject.Application.Services.Employees;
using Microsoft.Extensions.DependencyInjection;

namespace MaximCRMTestProject.Infrastructure;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure (this IServiceCollection services)
  {
    services.AddScoped<IEmployeeService, EmployeeService>();
    
    return services;
  }
}