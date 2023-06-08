namespace MaximCRMTestProject.Domain.Entities
{
    public sealed class EmployeeWithSameFullNameException : Exception
    {
        public EmployeeWithSameFullNameException(string fullName)
            : base($"The employee with the full name = {fullName} already exists.")
        {

        }
    }
}
