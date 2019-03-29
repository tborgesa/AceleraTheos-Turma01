using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SistemaEscola.Dominio.Horista;
using SistemaEscola.Dominio.Horista.Interfacecs;


namespace SistemaEscola.Api.Controllers
{
    [RoutePrefix("horista")]
    public class HoristaController : ApiController
    {
        private readonly IHoristaService _horistaService;

        public HoristaController(IHoristaService horistaService)
        {
            _horistaService = horistaService;
        }

        [HttpGet]
        [Route("getAll")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _horistaService.BuscarTodos());
        }
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var fornecedorDto = _horistaService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, fornecedorDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] HoristaInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var horistaDtoReturn = _horistaService.Inserir(viewModel);

            if (horistaDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, horistaDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, horistaDtoReturn.Horista);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] HoristaAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var horistaDtoReturn = _horistaService.Atualizar(viewModel);

            if (horistaDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, horistaDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, horistaDtoReturn.Horista);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _horistaService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}