//using System;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using AceleraPizza.Dominio.PedidoIngredientes;
//using AceleraPizza.Dominio.PedidoIngredientes.Interfaces;

//namespace AceleraPizza.Api.Controllers
//{
//    [RoutePrefix("PedidoIngredientes")]
//    public class PedidoIngredientesController : ApiController
//    {
//        private readonly IPedidoIngredientesService _PedidoIngredientesService;

//        public PedidoIngredientesController(IPedidoIngredientesService PedidoIngredientesService)
//        {
//            _PedidoIngredientesService = PedidoIngredientesService;
//        }

//        [HttpGet]
//        [Route("getAll")]
//        public HttpResponseMessage GetAll()
//        {
//            return Request.CreateResponse(HttpStatusCode.OK, _PedidoIngredientesService.BuscarTodos());
//        }
//        [HttpGet]
//        [Route("{id}")]
//        public HttpResponseMessage Get(Guid id)
//        {
//            if (id == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

//            var PedidoIngredientesDto = _PedidoIngredientesService.BuscarPorId(id);
//            return Request.CreateResponse(HttpStatusCode.OK, PedidoIngredientesDto);
//        }

//        [HttpPost]
//        [Route("")]
//        public HttpResponseMessage Post([FromBody] PedidoIngredientesInserirViewModel viewModel)
//        {
//            if (viewModel == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

//            var PedidoIngredientesDtoReturn = _PedidoIngredientesService.Inserir(viewModel);

//            if (PedidoIngredientesDtoReturn.Erros.Count > 0)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, PedidoIngredientesDtoReturn.Erros);

//            return Request.CreateResponse(HttpStatusCode.Created, PedidoIngredientesDtoReturn.PedidoIngredientes);
//        }

//        [HttpPut]
//        [Route("")]
//        public HttpResponseMessage Put([FromBody] PedidoIngredientesAtualizarViewModel viewModel)
//        {
//            if (viewModel == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Json inválido.");

//            var PedidoIngredientesDtoReturn = _PedidoIngredientesService.Atualizar(viewModel);

//            if (PedidoIngredientesDtoReturn.Erros.Count > 0)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, PedidoIngredientesDtoReturn.Erros);

//            return Request.CreateResponse(HttpStatusCode.Created, PedidoIngredientesDtoReturn.PedidoIngredientes);
//        }

//        [HttpDelete]
//        [Route("{id}")]
//        public HttpResponseMessage Delete(Guid id)
//        {
//            if (id == null)
//                return Request.CreateResponse(HttpStatusCode.BadRequest, "Id inválido.");

//            _PedidoIngredientesService.Excluir(id);
//            return Request.CreateResponse(HttpStatusCode.NoContent);
//        }

//    }
//}