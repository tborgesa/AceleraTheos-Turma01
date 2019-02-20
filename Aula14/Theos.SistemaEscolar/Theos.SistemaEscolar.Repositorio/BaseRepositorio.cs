using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Repositorio.Map;

namespace Theos.SistemaEscolar.Repositorio
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

            if (string.IsNullOrWhiteSpace(host) || string.IsNullOrWhiteSpace(database))
                throw new Exception("Dados da conexão inválidos ou inexistentes");

            var builder = new SqlConnectionStringBuilder
            {
                ApplicationName = "THEOS_SISTEMAESCOLAS",
                DataSource = host,
                InitialCatalog = database,
                UserID = "sa",
                Password = "sys@36911",
                ConnectRetryCount = 1,
                ConnectTimeout = 120,
                MinPoolSize = 2,
                MaxPoolSize = 10,
            };

            return builder.ConnectionString;
        }
    }
}
