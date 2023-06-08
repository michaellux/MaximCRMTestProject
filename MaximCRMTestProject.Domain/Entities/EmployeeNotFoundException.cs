namespace MaximCRMTestProject.Domain.Entities
{
    public sealed class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(EmployeeId id)
            :base($"The employee with the ID = {id.Value} was not found.")
        {
        
        }
    }
}
