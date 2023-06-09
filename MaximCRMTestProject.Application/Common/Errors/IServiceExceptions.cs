using System.Net;

namespace MaximCRMTestProject.Application.Common.Errors
{
    public interface IServiceException
    {
        public HttpStatusCode StatusCode { get; }
        public string ErrorMessage { get; set; }
    }
}
