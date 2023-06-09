using System.Net;

namespace MaximCRMTestProject.Application.Common.Errors
{
    public sealed class EmployeeWithSameFullNameException : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        public string ErrorMessage { get; set; }

        public EmployeeWithSameFullNameException(string fullName)
            : base($"The employee with the full name = {fullName} already exists.")
        {
            ErrorMessage = $"The employee with the full name = {fullName} already exists.";
        }
    }
}
