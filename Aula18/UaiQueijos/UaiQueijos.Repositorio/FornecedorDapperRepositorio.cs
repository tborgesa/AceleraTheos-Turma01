using Dapper;
using Dommel;
using System;
using System.Collections.Generic;
using System.Linq;
using UaiQueijos.Dominio.Fornecedor;

namespace UaiQueijos.Repositorio
{
    public class FornecedorDapperRepositorio : BaseRepositorio
    {
        public void Inserir(Fornecedor fornecedor)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(fornecedor);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Fornecedor BuscarPorCpf(string cpf)
        {
            try
            {
                Conexao.Open();

                var sql = "SELECT * FROM FORNECEDOR WHERE CPF = @CPF";

                var parametros = new DynamicParameters();
                parametros.Add("CPF", new DbString { Value = cpf, IsAnsi = true, Length = 14 });

                return Conexao.Query<Fornecedor>(sql, parametros).FirstOrDefault();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Fornecedor BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Fornecedor>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Fornecedor> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Fornecedor>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Fornecedor fornecedor)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(fornecedor);
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
                Conexao.Delete(new Fornecedor() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}