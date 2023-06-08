using Microsoft.EntityFrameworkCore;

namespace MaximCRMTestProject.Application.Services.Employees
{
    public interface IEmployeeDbContext : IDisposable
    {
        DbContext Instance { get; }
    }
}
