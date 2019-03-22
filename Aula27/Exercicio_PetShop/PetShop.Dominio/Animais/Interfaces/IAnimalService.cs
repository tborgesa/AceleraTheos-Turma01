using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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