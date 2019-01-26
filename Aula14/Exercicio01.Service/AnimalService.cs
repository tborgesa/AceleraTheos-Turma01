using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio01.Repositorio;
using Exercicio01.Dominio.Animais;
using Exercicio01.Dominio.Enumerador;

namespace Exercicio01.Service
{
    public class AnimalService
    {
        private CachorroRepositorio _repositorioCachorro = new CachorroRepositorio();


        public AnimalDtoReturn Inserir(AnimalInserirViewModel animalViewModel)
        {
            switch (animalViewModel.TipoAnimal)
            {
                case EnumAnimal.Cachorro:
                    var cachorro = new Cachorro(animalViewModel.Nome, animalViewModel.Peso);

                    break;
                case EnumAnimal.Gato:
                    break;

                case EnumAnimal.Peixe:
                    break;

                default:
                    break;
            }

            return new AnimalDtoReturn(BuscarPorId(cachorro));
        }



    }
}
