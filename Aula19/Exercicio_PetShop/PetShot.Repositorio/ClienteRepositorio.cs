using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Dominio.Pessoas;

namespace PetShot.Repositorio
{
    public class ClienteRepositorio
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public void Inserir(Cliente cliente)
        {
            cliente.GerarId();
        }
       
    }
}
