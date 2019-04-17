using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.Pedido;
using AceleraPizza.Dominio.Pedido.Interfaces;

namespace AceleraPizza.Repositorio
{
    public class PedidoDapperRepositorio : BaseRepositorio, IPedidoRepositorio
    {
        public void Inserir(Pedido Pedido)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(Pedido);

            }
            finally
            {
                Conexao.Close();
            }
        }

        public Pedido BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Pedido>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Pedido> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Pedido>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Pedido Pedido)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(Pedido);
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
                Conexao.Delete(new Pedido() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}