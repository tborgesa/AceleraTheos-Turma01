using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace UaiQueijos.Api
{
    [Route("helloworld")]
    public class HelloWordController : ApiController
    {
        [HttpGet]
        public Task<HttpResponseMessage> Get()
        {
           return Task.FromResult(Request.CreateResponse(HttpStatusCode.OK,"Hello World"));
        }
    }
}