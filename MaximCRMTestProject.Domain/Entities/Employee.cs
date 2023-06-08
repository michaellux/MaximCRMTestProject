
namespace MaximCRMTestProject.Domain.Entities
{
    public class Employee
    {
        public Employee(EmployeeId id, string fullName, string position) {
            Id = id;
            FullName = fullName;
            Position = position;
        }

        public EmployeeId Id { get; private set; }
        public string FullName { get; private set; } = null!;
        public string Position { get; private set; } = null!;

        public void Update(string fullName, string position)
        {
            FullName = fullName;
            Position = position;
        }
    }
}
