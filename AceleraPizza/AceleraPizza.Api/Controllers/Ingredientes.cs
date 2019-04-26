using AceleraPizza.Dominio.Ingrediente;
using AceleraPizza.Dominio.Ingrediente.Interfaces;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AceleraPizza.Api.Controllers
{
    [RoutePrefix("ingrediente")]
    public class IngredienteController : ApiController
    {
        private readonly IIngredienteService _ingredienteService;

        public IngredienteController(IIngredienteService ingredienteService)
        {
            _ingredienteService = ingredienteService;
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage Get(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            var ingredienteDto = _ingredienteService.BuscarPorId(id);
            return Request.CreateResponse(HttpStatusCode.OK, ingredienteDto);
        }

        [HttpPost]
        [Route("")]
        public HttpResponseMessage Post([FromBody] IngredienteInserirViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var ingredienteDtoReturn = _ingredienteService.Inserir(viewModel);

            if (ingredienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, ingredienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, ingredienteDtoReturn.Ingrediente);
        }

        [HttpPut]
        [Route("")]
        public HttpResponseMessage Put([FromBody] IngredienteAtualizarViewModel viewModel)
        {
            if (viewModel == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

            var ingredienteDtoReturn = _ingredienteService.Atualizar(viewModel);

            if (ingredienteDtoReturn.Erros.Count > 0)
                return Request.CreateResponse(HttpStatusCode.BadRequest, ingredienteDtoReturn.Erros);

            return Request.CreateResponse(HttpStatusCode.Created, ingredienteDtoReturn.Ingrediente);
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage Delete(Guid id)
        {
            if (id == null)
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

            _ingredienteService.Excluir(id);
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }

    }
}