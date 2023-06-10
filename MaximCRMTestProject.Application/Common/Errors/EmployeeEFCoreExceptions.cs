using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MaximCRMTestProject.Application.Common.Errors
{
    public sealed class EmployeeEFCoreExceptions : Exception, IServiceException
    {
        public HttpStatusCode StatusCode => HttpStatusCode.Conflict;

        public string ErrorMessage { get; set; }

        public EmployeeEFCoreExceptions(string message)
           : base(message)
        {
            ErrorMessage = message;
        }
    }
}
