using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Dominio.Ingrediente.Interfaces;
using AceleraPizza.Dominio.Pedido;
using AceleraPizza.Dominio.Pedido.Interfaces;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;

namespace AceleraPizza.Service
{
    public class PedidoService : IPedidoService
    {
        private IPedidoRepositorio _repositorio;
        private IPedidoIngredienteRepositorio _repositorioPedidoIngrediente;
        private IIngredienteRepositorio _repositorioIngrediente;
        private IClienteRepositorio _repositorioCliente;

        public PedidoService(IPedidoRepositorio repositorio,
            IPedidoIngredienteRepositorio repositorioPedidoIngrediente,
            IIngredienteRepositorio repositorioIngrediente,
            IClienteRepositorio repositorioCliente)
        {
            _repositorio = repositorio;
            _repositorioPedidoIngrediente = repositorioPedidoIngrediente;
            _repositorioIngrediente = repositorioIngrediente;
            _repositorioCliente = repositorioCliente;
        }

        public PedidoDtoReturn Inserir(PedidoInserirViewModel pedidoViewModel)
        {
            var pedido = new Pedido(
                pedidoViewModel.Tamanho,
                pedidoViewModel.Borda,
                pedidoViewModel.GetListaIngredientes(pedidoViewModel.ListaIngredientes),
                pedidoViewModel.IdCliente
                );

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            pedido.GerarId();
            pedido.SetValorIngredientes(pedido, _repositorioIngrediente);
            pedido.DescontoPorIdade(_repositorioCliente, pedido);
            pedido.SetPedidoIngredienteLista(pedido.ListaIngredientes, pedido.Id, _repositorioPedidoIngrediente);
            _repositorio.Inserir(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        public PedidoDto BuscarPorId(Guid id)
        {
            Pedido pedido = _repositorio.BuscarPorId(id);

            if (pedido == null)
                return null;

            return new PedidoDto
            {
                Id = pedido.Id,
                Tamanho = pedido.Tamanho,
                Borda = pedido.Borda,
                ListaIngredientes =
                    pedido.GetListaPedidoIngrediente(
                    pedido.Id,
                    _repositorioPedidoIngrediente.BuscarTodos()),
                IdCliente = pedido.IdCliente,
                Total = pedido.Total
            };
        }

        public List<PedidoSearch> BuscarTodos()
        {
            List<Pedido> pedidos = _repositorio.BuscarTodos();

            List<PedidoSearch> retorno = new List<PedidoSearch>();

            foreach (var pedido in pedidos)
            {
                retorno.Add(new PedidoSearch
                {
                    Id = pedido.Id,
                    Tamanho = pedido.Tamanho,
                    ListaIngredientes =
                        pedido.GetListaPedidoIngrediente(
                        pedido.Id,
                        _repositorioPedidoIngrediente.BuscarTodos()),
                    Borda = pedido.Borda,
                    IdCliente = pedido.IdCliente,
                    Total = pedido.Total
                });
            }

            return retorno;
        }

        public PedidoDtoReturn Atualizar(PedidoAtualizarViewModel pedidoAtualizarViewModel)
        {
            var pedido = _repositorio.BuscarPorId(pedidoAtualizarViewModel.Id);

            if (pedido == null)
            {
                List<string> erros = new List<string>
                {
                    "Pedido não existe."
                };
                return new PedidoDtoReturn(erros);
            }

            ExcluiPedidoIngredientes(pedidoAtualizarViewModel.Id);
            pedido.AlterarTamanho(pedidoAtualizarViewModel.Tamanho);
            pedido.AlterarBorda(pedidoAtualizarViewModel.Borda);
            pedido.SetPedidoIngredienteLista(pedidoAtualizarViewModel.ListaIngredientes, pedidoAtualizarViewModel.Id, _repositorioPedidoIngrediente);
            pedido.SetValor();
            pedido.ListaIngredientes = pedidoAtualizarViewModel.ListaIngredientes;
            pedido.SetValorIngredientes(pedido, _repositorioIngrediente);
            pedido.DescontoPorIdade(_repositorioCliente, pedido);
            pedido.SetarAlteracao();

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            _repositorio.Atualizar(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        //TODO: Como seria o caso que nao instacia a classe Pedido
        private void ExcluiPedidoIngredientes(Guid id)
        {
            var lista = _repositorioPedidoIngrediente.BuscarTodos();
            foreach (var item in lista)
            {
                if (item.IdPedido == id) { _repositorioPedidoIngrediente.Excluir(item.Id); }
            }
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
            ExcluiPedidoIngredientes(id);
        }
    }
}