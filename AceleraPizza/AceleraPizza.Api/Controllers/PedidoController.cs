using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//todo:using AceleraPizza.Dominio.Pedido;
//todo:using AceleraPizza.Dominio.Pedido.Interfaces;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("pedido")]
    public class PedidoController : ApiController
    {
        private readonly IPedidoService _pedidoService;

        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _pedidoService.BuscarTodos());
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var fornecedorDto = _pedidoService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, fornecedorDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] PedidoInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var pedidoDtoReturn = _pedidoService.Inserir(viewModel);

            if (pedidoDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, pedidoDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, pedidoDtoReturn.Pedido);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] PedidoAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var pedidoDtoReturn = _pedidoService.Atualizar(viewModel);

            if (pedidoDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, pedidoDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, pedidoDtoReturn.Pedido);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _pedidoService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}