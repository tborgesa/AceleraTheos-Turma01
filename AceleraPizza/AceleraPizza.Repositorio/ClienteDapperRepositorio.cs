using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.Cliente;
using AceleraPizza.Dominio.Cliente.Interfaces;
using AceleraPizza.Repositorio;

namespace AceleraPizza.Repositorio
{
    public class ClienteDapperRepositorio : BaseRepositorio, IClienteRepositorio
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