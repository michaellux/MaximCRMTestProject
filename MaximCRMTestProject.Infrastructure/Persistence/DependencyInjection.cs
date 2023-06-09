using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

namespace MaximCRMTestProject.Infrastructure.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        services.AddDbContext<EmployeeDbContext>(options =>
        {
            options.UseSqlServer();
        });

        services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}