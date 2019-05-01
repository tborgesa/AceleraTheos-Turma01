using System;
using System.Collections.Generic;
using AceleraPizza.Dominio.Ingrediente;
using AceleraPizza.Dominio.Ingrediente.Interfaces;

namespace AceleraPizza.Service
{
    public class IngredienteService : IIngredienteService
    {
        private IIngredienteRepositorio _repositorio;

        public IngredienteService(IIngredienteRepositorio repositorio)
        {
            _repositorio = repositorio;
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

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}