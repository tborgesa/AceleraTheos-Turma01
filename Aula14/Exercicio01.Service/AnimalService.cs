using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Repositorio;
using Exercicio01.Dominio.Animais;
using Exercicio01.Dominio.Animais.ViewModelDto;
using Exercicio01.Dominio.Enumerador;

namespace Exercicio01.Service
{
    public class AnimalService
    {
        private CachorroRepositorio _repositorioCachorro = new CachorroRepositorio();
        private GatoRepositorio _repositorioGato = new GatoRepositorio();
        private PeixeRepositorio _repositorioPeixe = new PeixeRepositorio();
        private AnimalRepositorio _repositorioAnimal = new PeixeRepositorio();

        public AnimalDtoReturn Inserir(AnimalInserirViewModel animalViewModel)
        {
            switch (animalViewModel.TipoAnimal)
            {
                case EnumAnimal.Cachorro:
                    var cachorro = new Cachorro(animalViewModel.Nome, animalViewModel.Peso);
                    _repositorioCachorro.Inserir(cachorro);
                    return new AnimalDtoReturn(BuscarPorId(cachorro.Id));

                case EnumAnimal.Gato:
                    var gato = new Gato(animalViewModel.Nome, animalViewModel.Peso);
                    _repositorioGato.Inserir(gato);
                    return new AnimalDtoReturn(BuscarPorId(gato.Id));

                default:
                    var peixe = new Peixe(animalViewModel.Nome, animalViewModel.Largura, animalViewModel.Comprimento, animalViewModel.Altura);
                    _repositorioPeixe.Inserir(peixe);
                    return new AnimalDtoReturn(BuscarPorId(peixe.Id));
            }
        }



        public AnimalDto BuscarPorId(Guid id)
        {
            return AnimalDto oi;
        }


        public List<AnimalSearchDto> BuscarTodos()
        {

            List<Animal> animais = _repositorioAnimal.BuscarTodos();
            List<AnimalSearchDto> retorno = new List<AnimalSearchDto>();

            foreach (var animal in animais)
            {
                retorno.Add(new AnimalSearchDto { Id = animal.Id, Nome = animal.Nome });
            }

            return retorno;
        }
    }
}
