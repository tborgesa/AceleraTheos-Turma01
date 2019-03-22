using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using PetShop.Dominio.Pessoas;
using PetShot.Repositorio;
using PetShop.Dominio.Pessoas.Interfaces;

namespace PetShop.Repositorio
{
    public class ClienteAdoNetRepositorio : BaseRepositorio, IClienteRepositorio
    {
        public ClienteAdoNetRepositorio()
        {

        }

        public void Inserir(Cliente cliente)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    INSERT INTO [dbo].[Cliente]
                               ([IdCliente]
                               ,[DataInsercao]
                               ,[Nome]
                               ,[Telefone]
                               ,[Endereco]
                               ,[DataAlteracao])
                         VALUES
                               (@ClienteId
                               ,@DataInsercao
                               ,@Nome
                               ,@Telefone
                               ,@Endereco
                               ,@DataAlteracao)";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@ClienteId", cliente.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", cliente.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", cliente.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco).SqlDbType = SqlDbType.VarChar;

                if (cliente.DataAlteracao == null)
                    command.Parameters.AddWithValue("@DataAlteracao", DBNull.Value).SqlDbType = SqlDbType.SmallDateTime;
                else
                    command.Parameters.AddWithValue("@DataAlteracao", cliente.DataAlteracao.GetValueOrDefault()).SqlDbType = SqlDbType.SmallDateTime;

                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cliente BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM CLIENTE WHERE IDCLIENTE = @ClienteId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@ClienteId", id).SqlDbType = SqlDbType.UniqueIdentifier;

                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var cliente = new Cliente();
                cliente.Id = (Guid)reader["IdCliente"];
                cliente.DataInsercao = (DateTime)reader["DataInsercao"];

                if (reader["DataAlteracao"] != DBNull.Value)
                    cliente.DataAlteracao = (DateTime)reader["DataAlteracao"];

                cliente.Nome = reader["Nome"].ToString();
                cliente.Telefone = reader["Telefone"].ToString();

                if (reader["Endereco"] != DBNull.Value)
                    cliente.Endereco = reader["Endereco"].ToString();

                return cliente;

            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Cliente> BuscarTodos()
        {
            try
            {
                Conexao.Open();

                var sql = @"SELECT * FROM CLIENTE";
                SqlCommand command = new SqlCommand(sql, Conexao);
                var reader = command.ExecuteReader();
                var clientes = new List<Cliente>();

                while (reader.Read())
                {
                    var cliente = new Cliente();
                    cliente.Id = (Guid)reader["IdCliente"];
                    cliente.DataInsercao = (DateTime)reader["DataInsercao"];

                    if (reader["DataAlteracao"] != DBNull.Value)
                        cliente.DataAlteracao = (DateTime)reader["DataAlteracao"];

                    cliente.Nome = reader["Nome"].ToString();
                    cliente.Telefone = reader["Telefone"].ToString();

                    if (reader["Endereco"] != DBNull.Value)
                        cliente.Endereco = reader["Endereco"].ToString();

                    clientes.Add(cliente);
                }

                return clientes;
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar(Cliente cliente)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    UPDATE [dbo].[Cliente]
                       SET [IdCliente] = @IdCliente
                          ,[DataInsercao] = @DataInsercao
                          ,[Nome] = @Nome
                          ,[Telefone] = @Telefone
                          ,[Endereco] = @Endereco
                          ,[DataAlteracao] = @DataAlteracao
                     WHERE [IdCliente] = @IdCliente";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IdCliente", cliente.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", cliente.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@Nome", cliente.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Telefone", cliente.Telefone).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Endereco", cliente.Endereco).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@DataAlteracao", cliente.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;

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

                var sql = @"DELETE FROM CLIENTE WHERE IDCLIENTE = @Id";

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
