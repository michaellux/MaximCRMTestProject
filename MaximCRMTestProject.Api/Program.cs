using MaximCRMTestProject.Application;
using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees;
using MaximCRMTestProject.Infrastructure.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly))
        .AddApplication()
        .AddInfrastructure()
        .AddControllers();
}
var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
