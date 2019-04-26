using System;
using System.Collections.Generic;
using System.Linq;
using Dommel;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Dominio.Funcionario.Interfaces;

namespace SistemaEscola.Repositorio
{
    public class ContratadoDapperRepositorio : BaseRepositorio , IContratadoRepositorio
    {
        public void Inserir(Contratado contratado)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(contratado);

            }
            finally
            {
                Conexao.Close();
            }
        }

        public Contratado BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Contratado>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        //Caso precise de consulta customisada
        //public Contratado BuscarPorCpf(string cpf)
        //{
        //    try
        //    {
        //        Conexao.Open();

        //        var sql = "SELECT * FROM CONTRATADO WHERE CPF = @CPF";

        //        var paramentros = new DynamicParameters();
        //        paramentros.Add("CPF", new DbString { Value = cpf, IsAnsi = true, Length = 14 });
        //        //True/False para quando nvarchar
                
        //        return Conexao.Query<Contratado>(sql, paramentros).FirstOrDefault() ;
        //        //Query tem o retorno do valor

        //    }
        //    finally
        //    {
        //        Conexao.Close();
        //    }
        //}

        public List<Contratado> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Contratado>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Contratado contratado)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(contratado);
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
                //Nova entidade para deletar o dado correspondente
                Conexao.Delete(new Contratado() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}