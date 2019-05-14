using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Ingrediente;
using AceleraPizza.Dominio.Ingrediente.Interfaces;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;

namespace AceleraPizza.Service
{
    public class IngredienteService : IIngredienteService
    {
        private IIngredienteRepositorio _repositorio;
        private IPedidoIngredienteRepositorio _repositorioPedidoIngrediente;

        public IngredienteService(IIngredienteRepositorio repositorio, IPedidoIngredienteRepositorio repositorioPedidoIngrediente)
        {
            _repositorio = repositorio;
            _repositorioPedidoIngrediente = repositorioPedidoIngrediente;
        }

        public IngredienteDtoReturn Inserir(IngredienteInserirViewModel ingredienteViewModel)
        {
            var ingrediente = new Ingrediente(
                ingredienteViewModel.Descricao,
                ingredienteViewModel.Valor
                );

            if (!ingrediente.Valido())
                return new IngredienteDtoReturn(ingrediente.GetErros());

            ingrediente.GerarId();
            _repositorio.Inserir(ingrediente);

            return new IngredienteDtoReturn(BuscarPorId(ingrediente.Id));
        }

        public IngredienteDto BuscarPorId(Guid id)
        {
            Ingrediente ingrediente = _repositorio.BuscarPorId(id);

            if (ingrediente == null)
                return null;

            return new IngredienteDto
            {
                Id = ingrediente.Id,
                Descricao = ingrediente.Descricao,
                Valor = ingrediente.Valor
            };
        }

        public IngredienteDtoReturn Atualizar(IngredienteAtualizarViewModel ingredienteAtualizarViewModel)
        {
            var ingrediente = _repositorio.BuscarPorId(ingredienteAtualizarViewModel.Id);

            if (ingrediente == null)
            {
                List<string> erros = new List<string>
                {
                    "Ingrediente não existe."
                };
                return new IngredienteDtoReturn(erros);
            }

            ingrediente.AlteraIngrediente(ingredienteAtualizarViewModel);

            if (!ingrediente.Valido())
                return new IngredienteDtoReturn(ingrediente.GetErros());



            _repositorio.Atualizar(ingrediente);

            return new IngredienteDtoReturn(BuscarPorId(ingrediente.Id));
        }

        public string Excluir(Guid id)
        {
            if (!_repositorioPedidoIngrediente.BuscarPorCliente(id))
            {
                _repositorio.Excluir(id);
            }
            return "Existe um ou mais pedidos para este Ingrediente.";
        }
    }
}