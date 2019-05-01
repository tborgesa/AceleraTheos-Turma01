using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Dominio.Ingrediente.Interfaces;
using AceleraPizza.Dominio.Pedido;
using AceleraPizza.Dominio.Pedido.Interfaces;
using AceleraPizza.Dominio.PedidoIngrediente;
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
            //TODO: Realizar este tipo de manobra quando valor do ingrediente deve ser consultado no caso de INSERT e UPDATE este seria mais correto?
            pedido.Total += SetValorIngrediente(pedido.ListaIngredientes);
            pedido.DescontoPorIdade(_repositorioCliente.BuscarPorId(pedido.IdCliente));
            SetPedidoIngredienteLista(pedido.ListaIngredientes, pedido.Id);
            _repositorio.Inserir(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        private void SetPedidoIngredienteLista(List<PedidoIngrediente> listaIngredientes, Guid id)
        {
            foreach (var item in listaIngredientes)
            {
                item.GerarId();
                item.IdPedido = id;
                _repositorioPedidoIngrediente.Inserir(item);
            }
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
            pedido.AlterarPedido(
                pedidoAtualizarViewModel,
                _repositorioCliente.BuscarPorId(pedido.IdCliente),
                SetValorIngrediente(pedidoAtualizarViewModel.ListaIngredientes)
                );
            SetPedidoIngredienteLista(pedidoAtualizarViewModel.ListaIngredientes, pedidoAtualizarViewModel.Id);

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            _repositorio.Atualizar(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        private double SetValorIngrediente(List<Dominio.PedidoIngrediente.PedidoIngrediente> listaIngredientes)
        {
            double totalIngredientes = 0;
            foreach (var item in listaIngredientes)
            {
                var ingrediente = _repositorioIngrediente.BuscarPorId(item.IdIngrediente);
                totalIngredientes += ingrediente.Valor * item.Quantidade;
            }
            return totalIngredientes;
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