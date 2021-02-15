using PetShop.Dominio.Animais;
using PetShot.Repositorio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PetShop.Dominio.Animais.Enumerador;

namespace PetShop.Repositorio
{
    public class CachorroAdoNetRepositorio : BaseRepositorio
    {
        public void Inserir(Cachorro cachorro)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    INSERT INTO [dbo].[Cachorro]
                               ([IdCachorro]
                               ,[DataInsercao]
                               ,[NomeCachorro]
                               ,[IdCliente]
                               ,[IdEspecie]
                               ,[Raca]
                               ,[Peso]
                               ,[ValorLimpeza]
                               ,[DataAlteracao])
                         VALUES
                               (@IdCachorro
                               ,@DataInsercao
                               ,@NomeCachorro
                               ,@IdCliente
                               ,@IdEspecie
                               ,@Raca
                               ,@Peso
                               ,@ValorLimpeza
                               ,@DataAlteracao
";
                SqlCommand comman = new SqlCommand(sql, Conexao);

                comman.Parameters.AddWithValue("@IdCachorro", cachorro.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                comman.Parameters.AddWithValue("@DataInsercao", cachorro.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                comman.Parameters.AddWithValue("@NomeCachorro", cachorro.Nome).SqlDbType = SqlDbType.VarChar;
                comman.Parameters.AddWithValue("@IdCliente", cachorro.Cliente.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                comman.Parameters.AddWithValue("@IdEspecie", 1).SqlDbType = SqlDbType.UniqueIdentifier;
                comman.Parameters.AddWithValue("@Raca", cachorro.Raca).SqlDbType = SqlDbType.VarChar;
                comman.Parameters.AddWithValue("@Peso", cachorro.Peso).SqlDbType = SqlDbType.Real;
                comman.Parameters.AddWithValue("@ValorLimpeza", cachorro.ValorLimpeza).SqlDbType = SqlDbType.Real;

                if (cachorro.DataAlteracao == null)
                    comman.Parameters.AddWithValue("@DataAlteracao", DBNull.Value).SqlDbType = SqlDbType.SmallDateTime;
                else
                    comman.Parameters.AddWithValue("@DataAlteracao", cachorro.DataAlteracao).SqlDbType = SqlDbType.SmallDateTime;

                comman.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public Cachorro BuscarPorId(Guid id)
        {
            try
            {
                Conexao.Open();
                var sql = @"SELECT * FROM CACHORRO WHERE IDCACHORRO = @CachorroId";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@CachorroId", id).SqlDbType = SqlDbType.UniqueIdentifier;

                var reader = command.ExecuteReader();
                if (!reader.Read()) return null;

                var cachorro = new Cachorro();
                cachorro.Id = (Guid)reader["IdCachorro"];
                cachorro.DataInsercao = (DateTime)reader["DataInsercao"];
                cachorro.Nome = reader["NomeCachorro"].ToString();

                if(reader["Raca"] != DBNull.Value)
                    cachorro.Raca = reader["Raca"].ToString();

                cachorro.Peso = (Double)reader["Peso"];
                cachorro.Cliente.Id = (Guid)reader["IdCliente"];

                if (reader["DataAlteracao"] != DBNull.Value)
                    cachorro.DataAlteracao = (DateTime)reader["DataAlteracao"];

                return cachorro;
            }
            finally
            {
                Conexao.Close();
            }
        }

        public List<Cachorro> BuscarTodos()
        {
            try
            {
                Conexao.Open();
                var sql = @"SELECT * FROM CACHORRO";
                SqlCommand command = new SqlCommand(sql, Conexao);
                var reader = command.ExecuteReader();
                var cachorros = new List<Cachorro>();

                while (reader.Read())
                {
                    var cachorro = new Cachorro();
                    cachorro.Id = (Guid)reader["IdCachorro"];
                    cachorro.DataInsercao = (DateTime)reader["DataInsercao"];
                    cachorro.Nome = reader["NomeCachorro"].ToString();

                    if (reader["Raca"] != DBNull.Value)
                        cachorro.Raca = reader["Raca"].ToString();

                    cachorro.Peso = (Double)reader["Peso"];
                    cachorro.Cliente.Id = (Guid)reader["IdCliente"];

                    if (reader["DataAlteracao"] != DBNull.Value)
                        cachorro.DataAlteracao = (DateTime)reader["DataAlteracao"];

                    cachorros.Add(cachorro);
                }

                return cachorros;
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Atualizar (Cachorro cachorro)
        {
            try
            {
                Conexao.Open();

                var sql = @"
                    UPDATE [dbo].[Cachorro]
                       SET [IdCachorro] = @IdCachorro
                          ,[DataInsercao] = @DataInsercao
                          ,[NomeCachorro] = @NomeCachorro
                          ,[IdCliente] = @IdCliente
                          ,[IdEspecie] = @IdEspecie
                          ,[Raca] = @Raca
                          ,[Peso] = @Peso
                          ,[ValorLimpeza] = @ValorLimpeza
                          ,[DataAlteracao] = @DataAlteracao
";
                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IdCachorro", cachorro.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@DataInsercao", cachorro.DataInsercao).SqlDbType = SqlDbType.SmallDateTime;
                command.Parameters.AddWithValue("@NomeCachorro", cachorro.Nome).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@IdCliente", cachorro.Cliente.Id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.Parameters.AddWithValue("@Raca", cachorro.Raca).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@Peso", cachorro.Peso).SqlDbType = SqlDbType.Real;
                command.Parameters.AddWithValue("@ValorLimpeza", cachorro.ValorLimpeza).SqlDbType = SqlDbType.Real;
                command.Parameters.AddWithValue("@DataAlteracao", cachorro.Id).SqlDbType = SqlDbType.SmallDateTime;

                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Excluir (Guid id)
        {
            try
            {
                Conexao.Open();

                var sql = @"DELETE FROM CACHORRO WHERE IDCACHORRO = @IdCachorro";

                SqlCommand command = new SqlCommand(sql, Conexao);

                command.Parameters.AddWithValue("@IdCachorro", id).SqlDbType = SqlDbType.UniqueIdentifier;
                command.ExecuteNonQuery();
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
