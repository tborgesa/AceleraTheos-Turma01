using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.Pedido;
using AceleraPizza.Dominio.Pedido.Interfaces;
using Dapper;

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

        bool IPedidoRepositorio.BuscarPorCliente(Guid idCliente)
        {
            try
            {
                Conexao.Open();

                var sql = "SELECT count(1) FROM PEDIDO WHERE IDCLIENTE = @IDCLIENTE";

                var paramentros = new DynamicParameters();
                paramentros.Add("@IDCLIENTE", dbType: System.Data.DbType.Guid, value: idCliente);

                return Conexao.Query<int>(sql, paramentros).FirstOrDefault() > 0;
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