using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using AceleraPizza.Dominio.Ingrediente;
using AceleraPizza.Dominio.Ingrediente.Interfaces;

namespace AceleraPizza.Repositorio
{
    public class IngredienteDapperRepositorio : BaseRepositorio, IIngredienteRepositorio
    {
        public void Inserir(Ingrediente Ingrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(Ingrediente);

            }
            finally
            {
                Conexao.Close();
            }
        }

        public Ingrediente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Ingrediente>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Ingrediente> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Ingrediente>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Ingrediente Ingrediente)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(Ingrediente);
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
                Conexao.Delete(new Ingrediente() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}