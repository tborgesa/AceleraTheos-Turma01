using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Dommel;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Dominio.Funcionario.Interfaces;

namespace SistemaEscola.Repositorio
{
    public class HoristaDapperRepositorio : BaseRepositorio , IHoristaRepositorio
    {
        public void Inserir(Horista horista)
        {
            try
            {
                Conexao.Open();
                Conexao.Insert(horista);

            }
            finally
            {
                Conexao.Close();
            }
        }

        public Horista BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                return Conexao.Get<Horista>(id);
            }
            finally
            {
                Conexao.Close();
            }
        }

        //Caso precise de consulta customisada
        //public Horista BuscarPorCpf(string cpf)
        //{
        //    try
        //    {
        //        Conexao.Open();

        //        var sql = "SELECT * FROM CONTRATADO WHERE CPF = @CPF";

        //        var paramentros = new DynamicParameters();
        //        paramentros.Add("CPF", new DbString { Value = cpf, IsAnsi = true, Length = 14 });
        //        //True/False para quando nvarchar
                
        //        return Conexao.Query<Horista>(sql, paramentros).FirstOrDefault() ;
        //        //Query tem o retorno do valor

        //    }
        //    finally
        //    {
        //        Conexao.Close();
        //    }
        //}

        public List<Horista> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                return Conexao.GetAll<Horista>().ToList();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Horista horista)
        {
            try
            {
                Conexao.Open();
                Conexao.Update(horista);
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
                Conexao.Delete(new Horista() { Id = id });
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}