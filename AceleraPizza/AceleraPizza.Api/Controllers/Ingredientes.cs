using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("ingredientes")]
    public class IngredientesController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "ingredientes ");
        }
    }
}