using MaximCRMTestProject.Api.Common.Errors;
using MaximCRMTestProject.Application;
using MaximCRMTestProject.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly))
        .AddApplication()
        .AddInfrastructure()
        .AddControllers();

    builder.Services.AddSingleton<ProblemDetailsFactory, EmployeeProblemDetailsFactory>();
}
var app = builder.Build();
{
    app.UseExceptionHandler("/error");
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
