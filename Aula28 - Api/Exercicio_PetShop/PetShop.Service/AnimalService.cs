using System;
using System.Collections.Generic;
using PetShop.Repositorio;
using PetShop.Dominio.Animais;
using PetShop.Dominio.Pessoas;
using PetShop.Dominio.Animais.Enumerador;
using PetShot.Repositorio;
using PetShop.Dominio.Pessoas.Interfaces;
using PetShop.Dominio.Animais.Interfaces;

namespace PetShop.Service
{
    public class AnimalService : IAnimalService
    {
        private ICachorroRepositorio _repositorio;

        public AnimalService(ICachorroRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        private CachorroDapperRepositorio _cachorros = new CachorroDapperRepositorio();
        private GatoRepositorio _gatos = new GatoRepositorio();
        private PeixeRepositorio _peixes = new PeixeRepositorio();

        public AnimalDtoReturn Inserir(AnimalInserirViewModel animalViewModel)
        {
            
            switch (animalViewModel.Especie)
            {
                case EnumEspecie.Cachorro:
                    var clienteServiceCachorro = new ClienteService();
                    var clienteCachorro = clienteServiceCachorro.BuscarModeloPorId(animalViewModel.DonoId);
                    var cachorro = new Cachorro(animalViewModel.Nome, clienteCachorro, EnumEspecie.Cachorro, animalViewModel.Peso);

                    if (!cachorro.Valido())
                    {

                    }
                    cachorro.GerarId();
                    _cachorros.Inserir(cachorro);

                    //var cachorroModel = (Cachorro) BuscarModeloPorId(cachorro.Id);

                    return new AnimalDtoReturn(BuscarPorId(cachorro.Id));

                case EnumEspecie.Gato:
                    var clienteServiceGato = new ClienteService();
                    var clienteGato = clienteServiceGato.BuscarModeloPorId(animalViewModel.DonoId);
                    var gato = new Gato(animalViewModel.Nome, clienteGato, EnumEspecie.Gato, animalViewModel.Peso);

                    if (!gato.Valido())
                        return new AnimalDtoReturn(gato.GetErros());

                    _gatos.Inserir(gato);

                    return new AnimalDtoReturn(BuscarPorId(gato.Id));

                case EnumEspecie.Peixe:
                    var clienteServicePeixe = new ClienteService();
                    var clientePeixe = clienteServicePeixe.BuscarModeloPorId(animalViewModel.DonoId);
                    var peixe = new Peixe(animalViewModel.Nome, clientePeixe, EnumEspecie.Peixe, animalViewModel.Altura, animalViewModel.Largura, animalViewModel.Comprimento);

                    if (!peixe.Valido())
                        return new AnimalDtoReturn(peixe.GetErros());

                    _peixes.Inserir(peixe);
                    return new AnimalDtoReturn(BuscarPorId(peixe.Id));

                default:
                    return null; 
            }

           // return animal;
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
            List<Gato> gatos = _gatos.BuscarTodos();
            foreach (Gato gato in gatos)
                animais.Add(gato);

            List<Peixe> peixes = _peixes.BuscarTodos();
            foreach (Peixe peixe in peixes)
                animais.Add(peixe);

            return animais;
        }

        List<Animal> IAnimalService.BuscarAnimais()
        {
            throw new NotImplementedException();
        }
    }
}
