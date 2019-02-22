using System;
using System.Collections.Generic;
using PetShop.Dominio.Animal.Gato;
using PetShop.Dominio.Animal;
using PetShop.Repositorio;

namespace PetShop.Service
{
    public class GatoService
    {
        private GatoRepositorio _repositorio = new GatoRepositorio();

        public GatoDto Inserir(GatoInserirViewModel gatoViewModel)
        {
            var gato = new Gato(
                gatoViewModel.NomeAnimal,
                gatoViewModel.NomeDono,
                gatoViewModel.CpfDono,
                gatoViewModel.Peso);

            _repositorio.Inserir(gato);

            return BuscarPorId(gato.Id);
        }

        public GatoDto BuscarPorId(Guid id)
        {
            Gato gato = _repositorio.BuscarPorId(id);

            return new GatoDto
            {
                Id = gato.Id,
                CpfDono = gato.CpfDono,
                DataInsercao = gato.DataInsercao,
                NomeAnimal = gato.NomeAnimal,
                NomeDono = gato.NomeDono,
                Peso = gato.Peso
            };
        }

        public List<AnimalSearch> BuscarTodos()
        {
            List<Gato> gatoes = _repositorio.BuscarTodos();

            List<AnimalSearch> retorno = new List<AnimalSearch>();

            foreach (var gato in gatoes)
            {
                retorno.Add(new AnimalSearch
                {
                    Id = gato.Id,
                    CpfDono = gato.CpfDono,
                    NomeAnimal = gato.NomeAnimal,
                    NomeDono = gato.NomeDono
                });
            }

            return retorno;
        }

        public GatoDto Atualizar(GatoAtualizarViewModel gatoAtualizarViewModel)
        {
            var gato = _repositorio.BuscarPorId(gatoAtualizarViewModel.Id);
            gato.AlterarPeso(gatoAtualizarViewModel.Peso);
            gato.SetarAlteracao();

            _repositorio.Atualizar(gato);

            return BuscarPorId(gatoAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}