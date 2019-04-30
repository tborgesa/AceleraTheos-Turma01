using System;
using System.Configuration;
using System.Data.SqlClient;
using Theos.Pizzaria.Repository.Map;

namespace Theos.Pizzaria.Repository
{
    public abstract class BaseRepository
    {
        protected SqlConnection Conexao;

        public BaseRepository()
        {
            ConfigMapDapper.Carregar();
            Conexao = new SqlConnection(GetStringConexao());
        }

        private string GetStringConexao()
        {
            var host = ConfigurationManager.AppSettings["DbHost"];
            var database = ConfigurationManager.AppSettings["DbName"];

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(database))
                throw new Exception("Dados de conexão com a base no arquivo de configuração inexistente.");

            var builder = new SqlConnectionStringBuilder
            {
                ApplicationName = "THEOS_PIZZARIA",
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
