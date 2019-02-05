using System;
using System.Collections.Generic;
using System.Linq;
using PetShop.Dominio.Pessoas;
using PetShop.Comum.Helpers;
using Newtonsoft.Json;

namespace PetShop.Repositorio
{
    public class ClienteRepositorio
    {
        private List<Cliente> _clientes = new List<Cliente>();

        public ClienteRepositorio()
        {
            _clientes = GetClientesArquivo();
        }

        public void Inserir(Cliente cliente)
        {
            cliente.GerarId();
            _clientes.Add(cliente);
            GravarClientesArquivo(_clientes);
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
            GravarClientesArquivo(_clientes);
        }

        public void Excluir(Guid id)
        {
            _clientes = _clientes.Where(c => c.Id != id).ToList();
            GravarClientesArquivo(_clientes);
        }

        private List<Cliente> GetClientesArquivo()
        {
            var conteudo = DataBaseHelper.LerArquivo("Cliene");
            var lista = JsonConvert.DeserializeObject<List<Cliente>>(conteudo);

            return lista ?? new List<Cliente>();
        }

        private void GravarClientesArquivo(List<Cliente> clientes)
        {
            var conteudo = JsonConvert.SerializeObject(clientes);
            DataBaseHelper.GravarArquivo(conteudo, "Clientes");
        }

    }
}
