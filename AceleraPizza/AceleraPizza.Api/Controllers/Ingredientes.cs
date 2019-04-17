//using System;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using AceleraPizza.Dominio.Ingredientes;
//using AceleraPizza.Dominio.Ingredientes.Interfaces;

//namespace AceleraPizza.Api.Controllers
//{
//    [RoutePrefix("ingredientes")]
//    public class IngredientesController : ApiController
//    {
//        private readonly IIngredientesService _ingredientesService;

//        public IngredientesController(IIngredientesService ingredientesService)
//        {
//            _ingredientesService = ingredientesService;
//        }

//        [HttpGet]
//        [Route("{id}")]
//        public HttpResponseMessage Get(Guid id)
//        {
//            if (id == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

//            var ingredientesDto = _ingredientesService.BuscarPorId(id);
//            return Request.CreateResponse(HttpStatusCode.OK, ingredientesDto);
//        }

//        [HttpPost]
//        [Route("")]
//        public HttpResponseMessage Post([FromBody] IngredientesInserirViewModel viewModel)
//        {
//            if (viewModel == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

//            var ingredientesDtoReturn = _ingredientesService.Inserir(viewModel);

//            if (ingredientesDtoReturn.Erros.Count > 0)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, ingredientesDtoReturn.Erros);

//            return Request.CreateResponse(HttpStatusCode.Created, ingredientesDtoReturn.Ingredientes);
//        }

//        [HttpPut]
//        [Route("")]
//        public HttpResponseMessage Put([FromBody] IngredientesAtualizarViewModel viewModel)
//        {
//            if (viewModel == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

//            var ingredientesDtoReturn = _ingredientesService.Atualizar(viewModel);

//            if (ingredientesDtoReturn.Erros.Count > 0)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, ingredientesDtoReturn.Erros);

//            return Request.CreateResponse(HttpStatusCode.Created, ingredientesDtoReturn.Ingredientes);
//        }

//        [HttpDelete]
//        [Route("{id}")]
//        public HttpResponseMessage Delete(Guid id)
//        {
//            if (id == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

//            _ingredientesService.Excluir(id);
//            return Request.CreateResponse(HttpStatusCode.NoContent);
//        }

//    }
//}