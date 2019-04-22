using System;
using System.Collections.Generic;
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


        public PedidoService(IPedidoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public PedidoDtoReturn Inserir(PedidoInserirViewModel pedidoViewModel)
        {
            var pedido = new Pedido(
                pedidoViewModel.Tamanho,
                pedidoViewModel.Borda,
                GetListaIngredientes(pedidoViewModel.ListaIngredientes),
                pedidoViewModel.IdCliente
                );

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            pedido.GerarId();
            _repositorio.Inserir(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        private List<_PedidoIngrediente> GetListaIngredientes(List<PedidoIngredienteInserirViewModel> listaIngredientes)
        {
            var lista = new List<_PedidoIngrediente>();
            foreach (var item in listaIngredientes)
            {
                lista.Add(new _PedidoIngrediente { Id = item.Id, Quantidade = item.Quantidade, IdIngrediente = item.IdIngrediente });
            }
            return lista;
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
                ListaIngredientes = pedido.ListaIngredientes,
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
                    ListaIngredientes = pedido.ListaIngredientes,
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

            pedido.AlterarTamanho(pedidoAtualizarViewModel.Tamanho);
            pedido.AlterarBorda(pedidoAtualizarViewModel.Borda);
            pedido.SetarAlteracao();

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            _repositorio.Atualizar(pedido);

            return new PedidoDtoReturn(BuscarPorId(pedido.Id));
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}