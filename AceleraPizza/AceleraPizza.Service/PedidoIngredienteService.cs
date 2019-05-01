using System;
using System.Collections.Generic;
using PedidoIngredienteAlias = AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;
using AceleraPizza.Dominio.PedidoIngredienteSearch;

namespace AceleraPizza.Service
{
    public class PedidoIngredienteService : IPedidoIngredienteService
    {
        private IPedidoIngredienteRepositorio _repositorio;

        public PedidoIngredienteService(IPedidoIngredienteRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public PedidoIngredienteAlias.PedidoIngredienteDtoReturn Inserir(PedidoIngredienteAlias.PedidoIngredienteInserirViewModel pedidoIngredienteViewModel)
        {
            var pedidoIngrediente = new PedidoIngredienteAlias.PedidoIngrediente(
                pedidoIngredienteViewModel.IdIngrediente,
                pedidoIngredienteViewModel.Quantidade
                );

            if (!pedidoIngrediente.Valido())
                return new PedidoIngredienteAlias.PedidoIngredienteDtoReturn(pedidoIngrediente.GetErros());

            pedidoIngrediente.GerarId();
            _repositorio.Inserir(pedidoIngrediente);

            return new PedidoIngredienteAlias.PedidoIngredienteDtoReturn(BuscarPorId(pedidoIngrediente.Id));
        }

        public PedidoIngredienteAlias.PedidoIngredienteDto BuscarPorId(Guid id)
        {
            PedidoIngredienteAlias.PedidoIngrediente pedidoIngrediente = _repositorio.BuscarPorId(id);

            if (pedidoIngrediente == null)
                return null;

            return new PedidoIngredienteAlias.PedidoIngredienteDto
            {
                Id = pedidoIngrediente.Id,
                IdIngrediente = pedidoIngrediente.IdIngrediente,
                 Quantidade= pedidoIngrediente.Quantidade
            };
        }

        public List<PedidoIngredienteSearch> BuscarTodos(Guid id)
        {
                List<PedidoIngredienteAlias.PedidoIngrediente> pedidoIngredientes = _repositorio.BuscarTodosIdPedido(id);
                List<PedidoIngredienteSearch> retorno = new List<PedidoIngredienteSearch>();

                if (pedidoIngredientes == null)
                    return null;

                foreach (var pedidoIngrediente in pedidoIngredientes)
                {
                    retorno.Add(new PedidoIngredienteSearch
                    {
                        Id = pedidoIngrediente.Id,
                        IdIngrediente = pedidoIngrediente.IdIngrediente,
                        Quantidade = pedidoIngrediente.Quantidade,
                    });
                }

                return retorno;
            }

            public void Excluir(Guid id)
        {
                _repositorio.Excluir(id);
        }
    }
}