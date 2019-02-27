using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaEscola.Dominio.Funcionario;
using SistemaEscola.Dominio.Funcionario.Interfaces;

namespace SistemaEscola.Repositorio
{
    public class HoristaAdoNetRepositorio : BaseRepositorio, IHoristaRepositorio
    {
        public void Inserir(Horista horista)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    INSERT INTO [dbo].[Horista]
                           ([HoristaId]
                           ,[DataInsercao]
                           ,[Nome]
                           ,[Cpf]
                           ,[DataNascimento]
                           ,[Endereco]
                           ,[Horas])
                     VALUES
                           (@HoristaId
                           ,@DataInsercao
                           ,@Nome
                           ,@Cpf
                           ,@DataNascimento
                           ,@Endereco
                           ,@Horas)";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@HoristaId", horista.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", horista.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", horista.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", horista.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", horista.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", horista.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Horas", horista.Horas).SqlDbType = SqlDbType.SmallInt;

                command.ExecuteNonQuery();
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

                var sql = @"SELECT * FROM HORISTA WHERE HORISTAID = @HoristaId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@HoristaId", id).SqlDbType = SqlDbType.UniqueIdentifier;


                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var horista = new Horista();
                horista.Id = (Guid)reader["HoristaId"];
                horista.DataInsercao = (DateTime)reader["DataInsercao"];

                if (reader["DataAlteracao"] != DBNull.Value)
                    horista.DataAlteracao = (DateTime)reader["DataAlteracao"];

                horista.Nome = reader["Nome"].ToString();
                horista.DataNascimento = (DateTime)reader["DataNascimento"];

                if (reader["Endereco"] != DBNull.Value)
                    horista.Endereco = reader["Endereco"].ToString();

                horista.Horas = (Int16)reader["Horas"];
                horista.Cpf = reader["Cpf"].ToString();

                return horista;
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Horista> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM HORISTA";

                SqlCommand command = new SqlCommand(sql, Conexao);

                var reader = command.ExecuteReader();

                var horistaes = new List<Horista>();

                while (reader.Read())
                {
                    var horista = new Horista();
                    horista.Id = (Guid)reader["HoristaId"];
                    horista.DataInsercao = (DateTime)reader["DataInsercao"];

                    if (reader["DataAlteracao"] != DBNull.Value)
                        horista.DataAlteracao = (DateTime)reader["DataAlteracao"];

                    horista.Nome = reader["Nome"].ToString();
                    horista.DataNascimento = (DateTime)reader["DataNascimento"];

                    if (reader["Endereco"] != DBNull.Value)
                        horista.Endereco = reader["Endereco"].ToString();

                    horista.Horas = (int)reader["Horas"];
                    horista.Cpf = reader["Cpf"].ToString();

                    horistaes.Add(horista);
                }

                return horistaes;
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

                var sql = @"
                    UPDATE [dbo].[Horista]
                    SET [DataInsercao] = @DataInsercao
                        ,[DataAlteracao] = @DataAlteracao
                        ,[Nome] = @Nome
                        ,[DataNascimento] = @DataNascimento
                        ,[Endereco] = @Endereco
                        ,[Horas] = @Horas
                        ,[Cpf] = @Cpf
                    WHERE HoristaId = @HoristaId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@HoristaId", horista.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", horista.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@DataAlteracao", horista.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", horista.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", horista.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", horista.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", horista.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Horas", horista.Horas).SqlDbType = SqlDbType.SmallInt;

                command.ExecuteNonQuery();
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

                var sql = @"DELETE FROM HORISTA WHERE HoristaId = @Id";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@Id", id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}