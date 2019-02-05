using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace SistemaEscola.Comum.Helpers
{
    public class DataBaseHelper
    {
        public static void GravarArquivo (string conteudo, string nomeArquivo)
        {
            var pasta = GetPastaConfigurada();
            var caminhoAbsoluto = $"{pasta}\\{nomeArquivo}.json";

            using (var arquivo = new StreamWriter(caminhoAbsoluto, false))
                arquivo.Write(conteudo);
        }

        public static string LerArquivo(string nomeArquivo)
        {
            var pasta = GetPastaConfigurada();
            var caminhoAbsoluto = $"{pasta}\\{nomeArquivo}.json";

            if (!File.Exists(caminhoAbsoluto))
            {
                var arquivo = File.Create(caminhoAbsoluto);
                arquivo.Close();
            }

            using (var arquivo = new StreamReader(caminhoAbsoluto))
                return arquivo.ReadToEnd();
        }

        private static string GetPastaConfigurada()
        {
            //Caminho Relativo: Destino parcial para caminhos da origem do arquivo.
            //Caminho Absoluto: Destino completo do arquivo.

            //Arquivo de Configuracao (Nome de ser o mesmo no App.config)
            var pasta = ConfigurationManager.AppSettings["PastaDataBase"];

            if (string.IsNullOrWhiteSpace(pasta))
                throw new Exception("Pasta do Banco de Dados nao configurado");

            //Tratamento para caso o caminho possua "\"
            if (pasta.EndsWith("\\"))
                pasta = pasta.Remove(pasta.Length - 1);

            //AssemblyExecution
            //var pastaExecutavel = System.Environment.CurrentDirectory;

            if (Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            return pasta;
        }
    }
}
