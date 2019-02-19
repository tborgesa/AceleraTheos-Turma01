using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio
{
    public class ContratadoAdoNetRepositorio : BaseRepositorio
    {
        public void Inserir(Contratado contratado)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    INSERT INTO [dbo].[Contratado]
                           ([ContratadoId]
                           ,[DataInsercao]
                           ,[Nome]
                           ,[Cpf]
                           ,[DataNascimento]
                           ,[Endereco]
                           ,[Escolaridade])
                     VALUES
                           (@ContratadoId
                           ,@DataInsercao
                           ,@Nome
                           ,@Cpf
                           ,@DataNascimento
                           ,@Endereco
                           ,@Escolaridade)";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@ContratadoId", contratado.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", contratado.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", contratado.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", contratado.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", contratado.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", contratado.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Escolaridade", contratado.Escolaridade).SqlDbType = SqlDbType.SmallInt;

                command.ExecuteNonQuery();
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

                var sql = @"SELECT * FROM CONTRATADO WHERE CONTRATADOID = @ContratadoId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@ContratadoId", id).SqlDbType = SqlDbType.UniqueIdentifier;


                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var contratado = new Contratado();
                contratado.Id = (Guid)reader["ContratadoId"];
                contratado.DataInsercao = (DateTime)reader["DataInsercao"];

                if (reader["DataAlteracao"] != DBNull.Value)
                    contratado.DataAlteracao = (DateTime)reader["DataAlteracao"];

                contratado.Nome = reader["Nome"].ToString();
                contratado.DataNascimento = (DateTime)reader["DataNascimento"];

                if (reader["Endereco"] != DBNull.Value)
                    contratado.Endereco = reader["Endereco"].ToString();

                //contratado.Escolaridade = (Int16)reader["Escolaridade"];
                contratado.Cpf = reader["Cpf"].ToString();

                return contratado;
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Contratado> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM CONTRATADO";

                SqlCommand command = new SqlCommand(sql, Conexao);

                var reader = command.ExecuteReader();

                var contratadoes = new List<Contratado>();

                while (reader.Read())
                {
                    var contratado = new Contratado();
                    contratado.Id = (Guid)reader["ContratadoId"];
                    contratado.DataInsercao = (DateTime)reader["DataInsercao"];

                    if (reader["DataAlteracao"] != DBNull.Value)
                        contratado.DataAlteracao = (DateTime)reader["DataAlteracao"];

                    contratado.Nome = reader["Nome"].ToString();
                    contratado.DataNascimento = (DateTime)reader["DataNascimento"];

                    if (reader["Endereco"] != DBNull.Value)
                        contratado.Endereco = reader["Endereco"].ToString();

                    //contratado.Escolaridade = (int)reader["Escolaridade"];
                    contratado.Cpf = reader["Cpf"].ToString();

                    contratadoes.Add(contratado);
                }

                return contratadoes;
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

                var sql = @"
                    UPDATE [dbo].[Contratado]
                    SET [DataInsercao] = @DataInsercao
                        ,[DataAlteracao] = @DataAlteracao
                        ,[Nome] = @Nome
                        ,[DataNascimento] = @DataNascimento
                        ,[Endereco] = @Endereco
                        ,[Escolaridade] = @Escolaridade
                        ,[Cpf] = @Cpf
                    WHERE ContratadoId = @ContratadoId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@ContratadoId", contratado.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", contratado.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@DataAlteracao", contratado.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", contratado.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", contratado.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", contratado.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", contratado.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Escolaridade", contratado.Escolaridade).SqlDbType = SqlDbType.SmallInt;

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

                var sql = @"DELETE FROM CONTRATADO WHERE ContratadoId = @Id";

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