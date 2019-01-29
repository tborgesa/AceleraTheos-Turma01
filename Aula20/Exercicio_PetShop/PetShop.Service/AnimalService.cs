using System;
using System.Collections.Generic;
using PetShop.Repositorio;
using PetShop.Dominio.Animais;
using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;

namespace PetShop.Service
{
    public class AnimalService
    {
        private CachorroRepositorio _cachorros = new CachorroRepositorio();


        public AnimalDtoReturn Inserir(AnimalInserirViewModel animalViewModel)
        {
            switch (animalViewModel.Especie)
            {
                case EnumEspecie.Cachorro:

                    var clienteService = new ClienteService();
                    var cliente = clienteService.BuscarModeloPorId(animalViewModel.DonoId);
                    var cachorro = new Cachorro(animalViewModel.Nome, cliente, EnumEspecie.Cachorro, animalViewModel.Peso);

                    if (!cachorro.Valido())
                        return new AnimalDtoReturn(cachorro.GetErros());

                    _cachorros.Inserir(cachorro);

                    //var cachorroModel = (Cachorro) BuscarModeloPorId(cachorro.Id);

                    return new AnimalDtoReturn(BuscarPorId(cachorro.Id));

            }
        }

        public Animal BuscarModeloPorId(Guid id)
        {
            List<Animal> animais = BuscarAnimais();
            return animais.Find(a => a.Id == id);
        }

        public AnimalDto BuscarPorId(Guid id)
        {
            var animal = BuscarModeloPorId(id);
            if (animal == null)
                return null;

            return new AnimalDto
            {
                Id = animal.Id,
                Nome = animal.Nome,
                Cliente = animal.Cliente
            };
        }


        private List<Animal> BuscarAnimais()
        {
            List<Animal> animais = new List<Animal>();

            //concatenar as listas
            List<Cachorro> cachorros = _cachorros.BuscarTodos();
            foreach (Cachorro cachorro in cachorros)
                animais.Add(cachorro);

            //adicionar o gatos e peixes na lista

            return animais;
        }
    }
}
