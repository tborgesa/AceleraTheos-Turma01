using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio
{
    public class ProfessorHoristaAdoNetRepositorio : BaseRepositorio
    {

        public void Inserir(ProfessorHorista professorHorista)
        {
            try
            {
                Conexao.Open();

                var sql = @"INSERT INTO[dbo].[PROFESSORHORISTA]
                               ([IDPROFESSORHORISTA]
                               ,[DATAINSERCAO]
                               ,[NOME]
                               ,[CPF]
                               ,[HORASTRABALHADAS])
                         VALUES
                               (@IDPROFESSORHORISTA
                               ,@DATAINSERCAO
                               ,@NOME
                               ,@CPF
                               ,@HORASTRABALHADAS)";
                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IDPROFESSORHORISTA", professorHorista.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DATAINSERCAO", professorHorista.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@NOME", professorHorista.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@CPF", professorHorista.Cpf).SqlDbType = SqlDbType.Char;
                command.Parameters.AddWithValue("@HORASTRABALHADAS", professorHorista.HorasTrabalhadas).SqlDbType = SqlDbType.Decimal;

                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(ProfessorHorista professorHorista)
        {
            try
            {
                Conexao.Open();

                var sql = @"UPDATE [dbo].[PROFESSORHORISTA]
                                   SET [DATAINSERCAO] = @DATAINSERCAO
                                      ,[DATAALTERACAO] = @DATAALTERACAO
                                      ,[NOME] = @NOME
                                      ,[CPF] = @CPF
                                      ,[HORASTRABALHADAS] = @HORASTRABALHADAS 
                                 WHERE IDPROFESSORHORISTA = @IDPROFESSORHORISTA";

                SqlCommand command = new SqlCommand(sql, Conexao);
                command.Parameters.AddWithValue("@IDPROFESSORHORISTA", professorHorista.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DATAINSERCAO", professorHorista.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@DATAALTERACAO", professorHorista.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@NOME", professorHorista.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@CPF", professorHorista.Cpf).SqlDbType = SqlDbType.Char;
                command.Parameters.AddWithValue("@HORASTRABALHADAS", professorHorista.HorasTrabalhadas).SqlDbType = SqlDbType.Decimal;

                command.ExecuteNonQuery();

            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Excluir(Guid id)
        {

        }

        public ProfessorHorista BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM PROFESSORHORISTA WHERE IDPROFESSORHORISTA = @IDPROFESSORHORISTA";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IDPROFESSORHORISTA", id).SqlDbType = SqlDbType.UniqueIdentifier;

                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var professorHorista = new ProfessorHorista();

                professorHorista.Id = (Guid)reader["IDPROFESSORHORISTA"];
                professorHorista.DataInsercao = (DateTime)reader["DATAINSERCAO"];

                if (reader["DATAALTERACAO"] != DBNull.Value)
                    professorHorista.DataAlteracao = (DateTime)reader["DATAALTERACAO"];

                professorHorista.Nome = reader["NOME"].ToString();
                professorHorista.Cpf = reader["CPF"].ToString();

                return professorHorista;
            }
            finally
            {
                Conexao.Close();
            }
        }


        public List<ProfessorHorista> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM PROFESSORHORISTA";

                SqlCommand command = new SqlCommand(sql, Conexao);

                var reader = command.ExecuteReader();

                var professoresHoristas = new List<ProfessorHorista>();

                while (reader.Read())
                {
                    var professorHorista = new ProfessorHorista();
                    professorHorista.Id = (Guid)reader["IDPROFESSORHORISTA"];
                    professorHorista.DataInsercao = (DateTime)reader["DATAINSERCAO"];

                    if (reader["DATAALTERACAO"] != DBNull.Value)
                        professorHorista.DataAlteracao = (DateTime)reader["DATAALTERACAO"];

                    professorHorista.Nome = reader["NOME"].ToString();
                    professorHorista.Cpf = reader["CPF"].ToString();


                    professoresHoristas.Add(professorHorista);

                }
                return professoresHoristas;
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
