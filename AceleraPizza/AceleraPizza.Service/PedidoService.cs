using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Pedido;
using AceleraPizza.Dominio.Pedido.Interfaces;

namespace AceleraPizza.Service
{
    public class PedidoService : IPedidoService
    {
        private IPedidoRepositorio _repositorio;

        public PedidoService(IPedidoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public PedidoDtoReturn Inserir(PedidoInserirViewModel pedidoViewModel)
        {
            var pedido = new Pedido(
                pedidoViewModel.Tamanho,
                pedidoViewModel.IdListaIngredientes,
                pedidoViewModel.Borda,
                pedidoViewModel.Cliente,
                pedidoViewModel.Total
                );

            if (!pedido.Valido())
                return new PedidoDtoReturn(pedido.GetErros());

            pedido.GerarId();
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
                IdListaIngredientes = pedido.IdListaIngredientes,
                Borda = pedido.Borda,
                Cliente = pedido.Cliente,
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
                    IdListaIngredientes = pedido.IdListaIngredientes,
                    Borda = pedido.Borda,
                    Cliente = pedido.Cliente,
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
                var erros = new List<string>();
                erros.Add("Pedido não existe.");
                return new PedidoDtoReturn(erros);
            }

            pedido.AlterarTamanho(pedidoAtualizarViewModel.Tamanho);
            pedido.AlterarIdListaIngredientes(pedidoAtualizarViewModel.IdListaIngredientes);
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