using EntityFramework.Exceptions.SqlServer;
using MaximCRMTestProject.Application.Services.Employees;
using MaximCRMTestProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MaximCRMTestProject.Infrastructure.Persistence
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {

        }

        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EmployeeDbContext).Assembly);

            FillTestData(modelBuilder);
        }

        private static void FillTestData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee(new EmployeeId(Guid.NewGuid()), 
                "Калмыков Макар Владимирович", 
                "кризис-менеджер")
             );

            modelBuilder.Entity<Employee>().HasData(
                new Employee(new EmployeeId(Guid.NewGuid()),
                "Швецова Яна Григорьевна",
                "эколог")
             );
            modelBuilder.Entity<Employee>().HasData(
                new Employee(new EmployeeId(Guid.NewGuid()),
                "Назаров Александр Львович",
                "рыбак")
             );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseExceptionProcessor();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MaximCRMTestProject");
        }
    }
}
