using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Dominio.Fornecedor.Interfaces;

namespace UaiQueijos.Api.Controllers
{
    [RoutePrefix("fornecedor")]
    public class FornecedorController : ApiController
    {
        private readonly IFornecedorService _fornecedorService;

        public FornecedorController(IFornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        [HttpGet]
        [Route("getall")]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _fornecedorService.BuscarTodos());
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var fornecedorDto = _fornecedorService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, fornecedorDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] FornecedorInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var fornecedorDtoReturn = _fornecedorService.Inserir(viewModel);

            if (fornecedorDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, fornecedorDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, fornecedorDtoReturn.Fornecedor);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] FornecedorAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var fornecedorDtoReturn = _fornecedorService.Atualizar(viewModel);

            if (fornecedorDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, fornecedorDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, fornecedorDtoReturn.Fornecedor);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _fornecedorService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}