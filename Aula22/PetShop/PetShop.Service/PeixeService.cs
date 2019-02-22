using System;
using System.Collections.Generic;
using PetShop.Dominio.Animal.Peixe;
using PetShop.Dominio.Animal;
using PetShop.Repositorio;

namespace PetShop.Service
{
    public class PeixeService
    {
        private PeixeRepositorio _repositorio = new PeixeRepositorio();

        public PeixeDto Inserir(PeixeInserirViewModel peixeViewModel)
        {
            var peixe = new Peixe(
                peixeViewModel.NomeAnimal,
                peixeViewModel.NomeDono,
                peixeViewModel.CpfDono,
                peixeViewModel.Altura,
                peixeViewModel.Largura,
                peixeViewModel.Comprimento);
        
        _repositorio.Inserir(peixe);

            return BuscarPorId(peixe.Id);
        }

        public PeixeDto BuscarPorId(Guid id)
        {
            Peixe peixe = _repositorio.BuscarPorId(id);

            return new PeixeDto
            {
                Id = peixe.Id,
                CpfDono = peixe.CpfDono,
                DataInsercao = peixe.DataInsercao,
                NomeAnimal = peixe.NomeAnimal,
                NomeDono = peixe.NomeDono,
                Largura = peixe.Largura,
                Altura = peixe.Altura,
                Comprimento = peixe.Comprimento
            };
        }

        public List<AnimalSearch> BuscarTodos()
        {
            List<Peixe> peixees = _repositorio.BuscarTodos();

            List<AnimalSearch> retorno = new List<AnimalSearch>();

            foreach (var peixe in peixees)
            {
                retorno.Add(new AnimalSearch
                {
                    Id = peixe.Id,
                    CpfDono = peixe.CpfDono,
                    NomeAnimal = peixe.NomeAnimal,
                    NomeDono = peixe.NomeDono
                });
            }

            return retorno;
        }

        public PeixeDto Atualizar(PeixeAtualizarViewModel peixeAtualizarViewModel)
        {
            var peixe = _repositorio.BuscarPorId(peixeAtualizarViewModel.Id);
            peixe.AlterarDimensao(peixeAtualizarViewModel.Altura, peixeAtualizarViewModel.Comprimento, peixeAtualizarViewModel.Largura);
            peixe.SetarAlteracao();

            _repositorio.Atualizar(peixe);

            return BuscarPorId(peixeAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}
