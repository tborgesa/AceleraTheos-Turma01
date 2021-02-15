using PetShop.Repositorio.Maps;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace PetShot.Repositorio
{
    public abstract class BaseRepositorio
    {
        protected SqlConnection Conexao;

        public BaseRepositorio()
        {
            ConfigMapDapper.Carregar();
            Conexao = new SqlConnection(GetStringConexao());
        }

        private string GetStringConexao()
        {
            var host = ConfigurationManager.AppSettings["DbHost"];
            var database = ConfigurationManager.AppSettings["DbName"];

            if(string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(database))
                throw new Exception("Dados de conexão com a base no arquivo de vonfiguração inexistente.");

            var builder = new SqlConnectionStringBuilder
            {
                ApplicationName = "PETSHOP",
                DataSource = host,
                InitialCatalog = database,
                UserID = "sa",
                Password = "sys@36911",
                ConnectRetryCount = 1,
                ConnectTimeout = 120,
                MinPoolSize = 5,
                MaxPoolSize = 10
            };
            
            return builder.ConnectionString;
        }
        
    }
}
