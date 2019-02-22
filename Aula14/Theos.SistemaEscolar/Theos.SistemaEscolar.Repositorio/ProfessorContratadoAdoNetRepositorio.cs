using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Interfaces;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorContratadoAdoNetRepositorio : BaseRepositorio, IProfessorContratadoRepositorio
    {

        public void Inserir(ProfessorContratado professorContratado)
        {
            try
            {
                Conexao.Open();
                var sql = @"INSERT INTO [dbo].[PROFESSORCONTRATADO]
                                   ([IDPROFESSORCONTRATADO]
                                   ,[DATAINSERCAO]
                                   ,[NOME]
                                   ,[CPF]
                                   ,[ESCOLARIDADE])
                                VALUES
                                   (@IDPROFESSORCONTRATADO
                                   ,@DATAINSERCAO
                                   ,@NOME
                                   ,@CPF
                                   ,@ESCOLARIDADE)";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IDPROFESSORCONTRATADO", professorContratado.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DATAINSERCAO", professorContratado.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@NOME", professorContratado.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@CPF", professorContratado.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@ESCOLARIDADE", professorContratado.Escolaridade).SqlDbType = SqlDbType.TinyInt;

                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }
        public void Atualizar(ProfessorContratado professorContratado)
        {
            try
            {
                Conexao.Open();

                var sql = @"UPDATE [dbo].[PROFESSORCONTRATADO]
                                   SET [DATAINSERCAO] = @DATAINSERCAO
                                      ,[DATAALTERACAO] = @DATAALTERACAO
                                      ,[NOME] = @NOME
                                      ,[CPF] = @CPF
                                      ,[ESCOLARIDADE] = @ESCOLARIDADE
                                 WHERE IDPROFESSORCONTRATADO = @IDPROFESSORCONTRATADO";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IDPROFESSORCONTRATADO", professorContratado.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DATAINSERCAO", professorContratado.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@DATAALTERACAO", professorContratado.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@NOME", professorContratado.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@CPF", professorContratado.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@ESCOLARIDADE", professorContratado.Escolaridade).SqlDbType = SqlDbType.TinyInt;

                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public ProfessorContratado BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM PROFESSORCONTRATADO WHERE IDPROFESSORCONTRATADO = @IDPROFESSORCONTRATADO";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IDPROFESSORCONTRATADO", id).SqlDbType = SqlDbType.UniqueIdentifier;

                var reader = command.ExecuteReader();

                if (!reader.Read()) return null;

                var professorContratado = new ProfessorContratado();

                professorContratado.Id = (Guid)reader["IDPROFESSORCONTRATADO"];
                professorContratado.DataInsercao = (DateTime)reader["DATAINSERCAO"];

                if (reader["DATAALTERACAO"] != DBNull.Value)
                    professorContratado.DataInsercao = (DateTime)reader["DATAALTERACAO"];

                professorContratado.Nome = reader["NOME"].ToString();
                professorContratado.Cpf = reader["CPF"].ToString();

                return professorContratado;

            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<ProfessorContratado> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM PROFESSORCONTRATADO";

                SqlCommand command = new SqlCommand(sql, Conexao);

                var reader = command.ExecuteReader();

                var professoresContratados = new List<ProfessorContratado>();

                while (reader.Read())
                {
                    var professorContratado = new ProfessorContratado();

                    professorContratado.Id = (Guid)reader["IDPROFESSORCONTRATADO"];
                    professorContratado.DataInsercao = (DateTime)reader["DATAINSERCAO"];

                    if (reader["DATAALTERACAO"] != DBNull.Value)
                        professorContratado.DataInsercao = (DateTime)reader["DATAALTERACAO"];

                    professorContratado.Nome = reader["NOME"].ToString();
                    professorContratado.Cpf = reader["CPF"].ToString();

                    professoresContratados.Add(professorContratado);
                 }

                return professoresContratados;
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
            }
            finally
            {
                Conexao.Close();
            }
        }

    }
}
