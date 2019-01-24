using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Repositorio;
using PetShop.Dominio.Animais;
using PetShop.Dominio.Animais.Enumerador;
using PetShot.Repositorio;

namespace PetShop.Service
{
    public class AnimalService
    {
        private void IdentificarEspecie(AnimalinserirViewModel animalViewModel)
        {
            switch (animalViewModel.Especie)
            {
                case EnumEspecie.Cachorro:

                    //buscar cliente

                    var cachorrro = new Cachorro(animalViewModel.Nome, null, animalViewModel.Peso);
                    

                    CachorroRepositorio.Inserir(animalViewModel);
                    break;
            }
        }
    }
}
