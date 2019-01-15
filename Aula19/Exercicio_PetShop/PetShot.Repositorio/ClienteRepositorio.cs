using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Dominio.Pessoas;

namespace PetShop.Repositorio
{
    public class ClienteRepositorio
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public void Inserir(Cliente cliente)
        {
            cliente.GerarId();
            _clientes.Add(cliente);
        }

        public Cliente BuscarPorId(Guid id)
        {
            return _clientes.FirstOrDefault(c => c.Id == id);
        }

        public List<Cliente> BuscarTodos()
        {
            return _clientes;
        }

        public void Atualizar(Cliente cliente)
        {
            var clienteLista = _clientes.FirstOrDefault(c => c.Id == cliente.Id);
            clienteLista = cliente;
        }

        public void Excluir(Guid id)
        {
            _clientes = _clientes.Where(c => c.Id != id).ToList();
        }
       
    }
}
