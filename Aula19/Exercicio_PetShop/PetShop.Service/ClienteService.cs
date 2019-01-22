using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Dominio.Pessoas;
using PetShop.Repositorio;
using static PetShop.Dominio.Pessoas.ClienteDto;

namespace PetShop.Service
{
    public class ClienteService
    {
        private ClienteRepositorio _repositorio = new ClienteRepositorio();

        public ClienteDtoReturn Inserir (ClinteInserirViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome, clienteViewModel.Telefone, clienteViewModel.Endereco);
            _repositorio.Inserir(cliente);

            if (!cliente.Valido())
                return new ClienteDtoReturn(cliente.GetErros());

            _repositorio.Inserir(cliente);
            return new ClienteDtoReturn(BuscarPorId(cliente.Id));
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

        public ClienteDto Atualizar(ClienteAtualizarViewModel clienteAtualizarViewModel)
        {
            var cliente = _repositorio.BuscarPorId(clienteAtualizarViewModel.Id);
            cliente.AlterarEndereco(clienteAtualizarViewModel.Endereco);
            cliente.AlterarTelefone(clienteAtualizarViewModel.Telefone);
            cliente.SetarAlteracao();

            _repositorio.Atualizar(cliente);

            return BuscarPorId(clienteAtualizarViewModel.Id);
        }

        public void Excluir(Guid id)
        {
            _repositorio.Excluir(id);
        }
    }
}
