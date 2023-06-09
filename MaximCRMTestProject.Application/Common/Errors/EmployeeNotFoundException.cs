using MaximCRMTestProject.Domain.Entities;
using System.Net;

namespace MaximCRMTestProject.Application.Common.Errors
{
    public sealed class EmployeeNotFoundException : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.NotFound;

        public string ErrorMessage { get; set; }

        public EmployeeNotFoundException(EmployeeId id)
            : base($"The employee with the ID = {id.Value} was not found.")
        {
            ErrorMessage = $"The employee with the ID = {id.Value} was not found.";
        }
    }
}
