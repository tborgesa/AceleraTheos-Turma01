using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;
using PetShop.Repositorio;

namespace PetShop.Service
{
    public class ClienteService
    {
        private ClienteRepositorio _repositorio = new ClienteRepositorio();

        public ClienteDto Inserir (ClinteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome, clienteViewModel.Telefone, clienteViewModel.Endereco);
            _repositorio.Inserir(cliente);
            return BuscarPorId(cliente.Id);
        }

        public ClienteDto BuscarPorId(Guid id)
        {
            Cliente cliente = _repositorio.BuscarPorId(id);

            return new ClienteDto
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco
            };
        }

        public List<ClienteSearch> BuscarTodos()
        {
            List<Cliente> clientes = _repositorio.BuscarTodos();

            List<ClienteSearch> retorno = new List<ClienteSearch>();

            foreach (var cliente in clientes)
            {
                retorno.Add(new ClienteSearch
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Endereco = cliente.Endereco
                });
            }

            return retorno;
        }
    }
}
