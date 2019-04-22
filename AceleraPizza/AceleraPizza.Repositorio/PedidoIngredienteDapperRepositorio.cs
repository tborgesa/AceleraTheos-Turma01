using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.PedidoIngrediente;
using AceleraPizza.Dominio.PedidoIngrediente.Interfaces;

namespace AceleraPizza.Repositorio
{
    public class PedidoIngredienteDapperRepositorio : BaseRepositorio, IPedidoIngredienteRepositorio
    {
        public void Inserir(_PedidoIngrediente PedidoIngrediente)
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

        public _PedidoIngrediente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<_PedidoIngrediente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<_PedidoIngrediente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<_PedidoIngrediente>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(_PedidoIngrediente PedidoIngrediente)
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
                Conexao.Delete(new _PedidoIngrediente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}