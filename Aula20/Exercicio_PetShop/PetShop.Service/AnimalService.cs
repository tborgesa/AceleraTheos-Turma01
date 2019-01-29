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

                    var clienteService = new ClienteService().BuscarPorId(animalViewModel.DonoId);
                    var cliente = new Cliente(clienteService.Nome, clienteService.Telefone, clienteService.Endereco);

                    var cachorro = new Cachorro(animalViewModel.Nome, cliente, animalViewModel.Peso);

                    //ver com o tiago se eu já posso instanciar ou se vai ter que ser separado.

                    if (!cachorro.Valido())
                        

                    break;
            }

        }

    public AnimalDto BuscarPorId(Guid id)
    {
        Animal animal = _animaisCadastrados.BuscarPorId(id);
    }
}
}
