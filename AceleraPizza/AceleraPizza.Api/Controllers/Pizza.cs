using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SistemaEscola.Api.Controllers
{
    [RoutePrefix("pizza")]
    public class PizzaController : ApiController
    {
        private readonly IpizzaService _pizzaService;

        public pizzaController(IpizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _pizzaService.BuscarTodos());
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var fornecedorDto = _pizzaService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, fornecedorDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] pizzaInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var pizzaDtoReturn = _pizzaService.Inserir(viewModel);

            if (pizzaDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, pizzaDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, pizzaDtoReturn.pizza);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] pizzaAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var pizzaDtoReturn = _pizzaService.Atualizar(viewModel);

            if (pizzaDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, pizzaDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, pizzaDtoReturn.pizza);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _pizzaService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}