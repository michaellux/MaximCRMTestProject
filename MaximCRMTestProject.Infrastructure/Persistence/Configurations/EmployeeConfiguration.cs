using MaximCRMTestProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaximCRMTestProject.Infrastructure.Persistence.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasConversion(
                employeeId => employeeId.Value,
                value => new EmployeeId(value));

            builder.HasIndex(e => e.FullName)
                .IsUnique();

            builder.Property(e => e.Position);
        }
    }
}
