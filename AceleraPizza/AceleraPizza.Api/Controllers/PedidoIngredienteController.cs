using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("api/v1/pedidoIngrediente")]
    public class PedidoIngredienteController : ApiController
    {
        private readonly IPedidoIngredienteService _pedidoIngredienteService;

        public PedidoIngredienteController(IPedidoIngredienteService pedidoIngredienteService)
        {
            _pedidoIngredienteService = pedidoIngredienteService;
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var pedidoIngredienteDto = _pedidoIngredienteService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, pedidoIngredienteDto);
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll(Guid id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, _pedidoIngredienteService.BuscarTodos(id));
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] PedidoIngredienteInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var pedidoIngredienteDtoReturn = _pedidoIngredienteService.Inserir(viewModel);

            if (pedidoIngredienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, pedidoIngredienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, pedidoIngredienteDtoReturn.PedidoIngrediente);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _pedidoIngredienteService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}