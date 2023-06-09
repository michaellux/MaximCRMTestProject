using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace MaximCRMTestProject.Infrastructure.Persistence
{
    public sealed class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee?> GetEmployeeByIdAsync(EmployeeId id)
        {
            return await _context.Employees.Where((employee) => employee.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Employee?> GetEmployeeByFullNameAsync(string fullName)
        {
            var targetEmployee = await _context.Employees.Where((employee) => employee.FullName == fullName).FirstOrDefaultAsync();
            return targetEmployee;
        }

        public Task<Employee?> GetEmployeeByFullName(string fullName)
        {
            var taskEmployee = _context.Employees.Where((employee) => employee.FullName == fullName).FirstOrDefaultAsync();
            return taskEmployee;
        }

        public async Task<Employee> UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
            return employee;
        }

        public async Task<Employee> RemoveAsync(Employee employee)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
    }
}
