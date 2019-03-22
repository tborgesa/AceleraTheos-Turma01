using System;
using System.Collections.Generic;

namespace PetShop.Dominio.Animais.Interfaces
{
    public interface IAnimalService
    {
        AnimalDtoReturn Inserir(AnimalInserirViewModel animalViewModel);
        Animal BuscarModeloPorId(Guid id);
        AnimalDto BuscarPorId(Guid id);
        List<Animal> BuscarAnimais();
    }
}
