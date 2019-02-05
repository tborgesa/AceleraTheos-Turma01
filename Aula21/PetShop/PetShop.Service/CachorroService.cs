using System;
using System.Collections.Generic;
using PetShop.Dominio.Animal.Cachorro;
using PetShop.Dominio.Animal;
using PetShop.Repositorio;

namespace PetShop.Service
{
    public class CachorroService
    {
        private CachorroRepositorio _repositorio = new CachorroRepositorio();

        public CachorroDto Inserir(CachorroInserirViewModel cachorroViewModel)
        {
            var cachorro = new Cachorro(
                cachorroViewModel.NomeAnimal,
                cachorroViewModel.NomeDono,
                cachorroViewModel.CpfDono, 
                cachorroViewModel.Peso);

            _repositorio.Inserir(cachorro);

            return BuscarPorId(cachorro.Id);
        }

        public CachorroDto BuscarPorId(Guid id)
        {
            Cachorro cachorro = _repositorio.BuscarPorId(id);

            return new CachorroDto
            {
                Id = cachorro.Id,
                CpfDono = cachorro.CpfDono,
                DataInsercao = cachorro.DataInsercao,
                NomeAnimal = cachorro.NomeAnimal,
                NomeDono = cachorro.NomeDono,
                Peso = cachorro.Peso
            };
        }

        public List<AnimalSearch> BuscarTodos()
        {
            List<Cachorro> cachorroes = _repositorio.BuscarTodos();

            List<AnimalSearch> retorno = new List<AnimalSearch>();

            foreach (var cachorro in cachorroes)
            {
                retorno.Add(new AnimalSearch
                {
                    Id = cachorro.Id,
                    CpfDono = cachorro.CpfDono,
                    NomeAnimal = cachorro.NomeAnimal,
                    NomeDono = cachorro.NomeDono
                });
            }

            return retorno;
        }

        public CachorroDto Atualizar(CachorroAtualizarViewModel cachorroAtualizarViewModel)
        {
            var cachorro = _repositorio.BuscarPorId(cachorroAtualizarViewModel.Id);
            cachorro.AlterarPeso(cachorroAtualizarViewModel.Peso);
            cachorro.SetarAlteracao();

            _repositorio.Atualizar(cachorro);

            return BuscarPorId(cachorroAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}