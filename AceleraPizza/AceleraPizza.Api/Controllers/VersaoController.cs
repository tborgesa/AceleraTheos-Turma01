using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("versao")]
    public class VersaoController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "1.02.5");
        }
    }
}