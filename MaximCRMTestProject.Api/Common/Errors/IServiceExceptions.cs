using System.Net;

namespace MaximCRMTestProject.Api.Common.Errors
{
    public interface IServiceExceptions
    {
        public HttpStatusCode StatusCode { get; }
        public string ErrorMessage { get; }
    }
}
