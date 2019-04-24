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

        public List<PedidoIngrediente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<PedidoIngrediente>().ToList();
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
    }
}