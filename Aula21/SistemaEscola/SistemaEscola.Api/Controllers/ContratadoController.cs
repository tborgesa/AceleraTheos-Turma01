using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SistemaEscola.Dominio.Contratado;
using SistemaEscola.Dominio.Contratado.Interfacecs;


namespace SistemaEscola.Api.Controllers
{
    [RoutePrefix("contratado")]
    public class ContratadoController : ApiController
    {
        private readonly IContratadoService _contratadoService;

        public ContratadoController(IContratadoService contratadoService)
        {
            _contratadoService = contratadoService;
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _contratadoService.BuscarTodos());
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var fornecedorDto = _contratadoService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, fornecedorDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] ContratadoInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var contratadoDtoReturn = _contratadoService.Inserir(viewModel);

            if (contratadoDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, contratadoDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, contratadoDtoReturn.Contratado);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] ContratadoAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var contratadoDtoReturn = _contratadoService.Atualizar(viewModel);

            if (contratadoDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, contratadoDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, contratadoDtoReturn.Contratado);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _contratadoService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}