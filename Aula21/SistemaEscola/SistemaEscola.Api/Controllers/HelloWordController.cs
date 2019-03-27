using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace SistemaEscola.Api.Controllers
{
    [RoutePrefix("helloworld")]
    public class HelloWordController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World");
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Get([FromBody] Temp dados)
        {
            return Request.CreateResponse(HttpStatusCode.OK, $"Hello World body, {dados.Nome}.");
        }

        [HttpGet]
        [Route("getbyid/{id}")]
        public HttpResponseMessage GetByRota(int id)
        {
            var temp = new Temp();
            temp.Codigo = id;
            temp.Nome = "teste";
            return Request.CreateResponse(HttpStatusCode.OK, temp);
        }

        [HttpGet]
        [Route("getbyid")]
        public HttpResponseMessage GetByQuery(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, $"Hello World query, {id}.");
        }

        public class Temp
        {
            public int Codigo { get; set; }
            public string Nome { get; set; }
            public decimal Valor { get; set; }
            public DateTime? Data { get; set; }
        }
    }
}