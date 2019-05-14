using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Theos.Pizzaria.Dominio.Cliente;
using Theos.Pizzaria.Dominio.Cliente.Interfaces;

namespace Theos.Pizzaria.Controllers
{
    [RoutePrefix("cliente")]
    public class ClienteController : ApiController
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] ClienteAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var clienteDtoReturn = _clienteService.Atualizar(viewModel);

            if (clienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, clienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, clienteDtoReturn.Cliente);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _clienteService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _clienteService.BuscarTodos());
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido ou inexistente.");

            var clienteDto = _clienteService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, clienteDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] ClienteInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var clienteDtoReturn = _clienteService.Inserir(viewModel);

            if (clienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, clienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, clienteDtoReturn.Cliente);
        }
    }
}