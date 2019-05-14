using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;
using Dapper;

namespace AceleraPizza.Repositorio
{
    public class PedidoIngredienteDapperRepositorio : BaseRepositorio, IPedidoIngredienteRepositorio
    {
        public void Inserir(PedidoIngrediente PedidoIngrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(PedidoIngrediente);

            }
            finally
            {
                Conexao.Close();
            }
        }

        public PedidoIngrediente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<PedidoIngrediente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        List<PedidoIngredienteViewModel> IPedidoIngredienteRepositorio.BuscarTodosIdPedido(Guid idPedido)
        {
            try
            {
                Conexao.Open();

                var sql = "SELECT * FROM PEDIDOINGREDIENTE WHERE IDPEDIDO = @IDPEDIDO";

                var paramentros = new DynamicParameters();
                paramentros.Add("@IDPEDIDO", dbType: System.Data.DbType.Guid, value: idPedido);

                return Conexao.Query<PedidoIngredienteViewModel>(sql, paramentros).ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(PedidoIngrediente PedidoIngrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(PedidoIngrediente);
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
                Conexao.Delete(new PedidoIngrediente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }

        public bool BuscarPorCliente(Guid id)
        {
            try
            {
                Conexao.Open();

                var sql = "SELECT count(1) FROM PEDIDOINGREDIENTE WHERE IDINGREDIENTE = @IDINGREDIENTE";

                var paramentros = new DynamicParameters();
                paramentros.Add("@IDINGREDIENTE", dbType: System.Data.DbType.Guid, value: id);

                return Conexao.Query<int>(sql, paramentros).FirstOrDefault() > 0;
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}