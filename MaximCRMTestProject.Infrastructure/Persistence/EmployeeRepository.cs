using MaximCRMTestProject.Application.Common.Interfaces.Persistence;
using MaximCRMTestProject.Domain.Entities;

namespace MaximCRMTestProject.Infrastructure.Persistence
{
    public sealed class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;

        public async Task<Employee> Add(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public EmployeeRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public Task<Employee?> GetEmployeeByFullName(string fullName)
        {
            throw new NotImplementedException();
        }

        public Task<Employee?> GetEmployeeByIdAsync(EmployeeId id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }

        //public EmployeeRepository(EmployeeDbContext context)
        //{
        //    _context = context;
        //}

        //private static readonly List<Employee> _employees = new();

        //public void Add(Employee employee)
        //{
        //    _employees.Add(employee);

        //}

        //public Employee? GetEmployeeByFullName(string fullName)
        //{
        //    return _employees.SingleOrDefault(emp => emp.FullName == fullName);
        //}

        //public Task<Employee?> GetEmployeeByIdAsync(EmployeeId id)
        //{
        //    return null;
        //}

        //public void Remove(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //Task<Employee?> IEmployeeRepository.GetEmployeeByFullName(string fullName)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
