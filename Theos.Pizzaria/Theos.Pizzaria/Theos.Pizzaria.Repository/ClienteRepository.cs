using System;
using Dommel;
using System.Collections.Generic;
using Theos.Pizzaria.Dominio.Cliente;
using Theos.Pizzaria.Dominio.Cliente.Interfaces;
using Theos.Pizzaria.Repository;
using System.Linq;

namespace Theos.Pizzaria.Service
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        public void Inserir(Cliente cliente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(cliente);
            }
            finally
            {
                Conexao.Close();
            }

        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(cliente);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cliente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Cliente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Cliente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Cliente>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Excluir(Guid id)
        {
            try
            {
                Conexao.Open();
                Conexao.Delete(new Cliente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
 
    }
}
