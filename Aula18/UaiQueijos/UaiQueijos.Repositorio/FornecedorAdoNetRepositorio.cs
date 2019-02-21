using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Dominio.Fornecedor.Interfaces;

namespace UaiQueijos.Repositorio
{
    public class FornecedorAdoNetRepositorio : BaseRepositorio, IFornecedorRepositorio
    {
        public void Inserir(Fornecedor fornecedor)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    INSERT INTO [dbo].[Fornecedor]
                           ([FornecedorId]
                           ,[DataInsercao]
                           ,[Nome]
                           ,[Cpf]
                           ,[DataNascimento]
                           ,[Endereco]
                           ,[NomeFantasia])
                     VALUES
                           (@FornecedorId
                           ,@DataInsercao
                           ,@Nome
                           ,@Cpf
                           ,@DataNascimento
                           ,@Endereco
                           ,@NomeFantasia)";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@FornecedorId", fornecedor.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", fornecedor.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", fornecedor.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", fornecedor.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", fornecedor.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia).SqlDbType = SqlDbType.VarChar;

                command.ExecuteNonQuery();
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

                var sql = @"SELECT * FROM FORNECEDOR WHERE FORNECEDORID = @FornecedorId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@FornecedorId", id).SqlDbType = SqlDbType.UniqueIdentifier;

                
                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var fornecedor = new Fornecedor();
                fornecedor.Id = (Guid) reader["FornecedorId"];
                fornecedor.DataInsercao = (DateTime) reader["DataInsercao"];

                if (reader["DataAlteracao"] != DBNull.Value)
                    fornecedor.DataAlteracao = (DateTime) reader["DataAlteracao"];

                fornecedor.Nome = reader["Nome"].ToString();
                fornecedor.DataNascimento = (DateTime) reader["DataNascimento"];

                if (reader["Endereco"] != DBNull.Value)
                    fornecedor.Endereco = reader["Endereco"].ToString();

                fornecedor.NomeFantasia = reader["NomeFantasia"].ToString();
                fornecedor.Cpf = reader["Cpf"].ToString();

                return fornecedor;
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

                var sql = @"SELECT * FROM FORNECEDOR";

                SqlCommand command = new SqlCommand(sql, Conexao);
                               
                var reader = command.ExecuteReader();

                var fornecedores = new List<Fornecedor>();

                while (reader.Read())
                {
                    var fornecedor = new Fornecedor();
                    fornecedor.Id = (Guid)reader["FornecedorId"];
                    fornecedor.DataInsercao = (DateTime)reader["DataInsercao"];

                    if (reader["DataAlteracao"] != DBNull.Value)
                        fornecedor.DataAlteracao = (DateTime)reader["DataAlteracao"];

                    fornecedor.Nome = reader["Nome"].ToString();
                    fornecedor.DataNascimento = (DateTime)reader["DataNascimento"];

                    if (reader["Endereco"] != DBNull.Value)
                        fornecedor.Endereco = reader["Endereco"].ToString();

                    fornecedor.NomeFantasia = reader["NomeFantasia"].ToString();
                    fornecedor.Cpf = reader["Cpf"].ToString();

                    fornecedores.Add(fornecedor);
                }

                return fornecedores;
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

                var sql = @"
                    UPDATE [dbo].[Fornecedor]
                    SET [DataInsercao] = @DataInsercao
                        ,[DataAlteracao] = @DataAlteracao
                        ,[Nome] = @Nome
                        ,[DataNascimento] = @DataNascimento
                        ,[Endereco] = @Endereco
                        ,[NomeFantasia] = @NomeFantasia
                        ,[Cpf] = @Cpf
                    WHERE FornecedorId = @FornecedorId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@FornecedorId", fornecedor.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", fornecedor.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@DataAlteracao", fornecedor.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", fornecedor.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Cpf", fornecedor.Cpf).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataNascimento", fornecedor.DataNascimento).SqlDbType = SqlDbType.Date;
                command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia).SqlDbType = SqlDbType.VarChar;

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

                var sql = @"DELETE FROM FORNECEDOR WHERE FornecedorId = @Id";

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