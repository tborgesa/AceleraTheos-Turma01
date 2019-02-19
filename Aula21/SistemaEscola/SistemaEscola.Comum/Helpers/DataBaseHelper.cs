using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;

namespace SistemaEscola.Comum.Helpers
{
    public static class DataBaseHelper
    {
        public static void GravarArquivo(string conteudo, string nomeArquivo)
        {
            var pasta = GetPastaConfigurada();
            var caminhoAbsoluto = $"{pasta}\\{nomeArquivo}.json";

            using (var arquivo = new StreamWriter(caminhoAbsoluto, false))
                arquivo.Write(conteudo);
        }

        public static List<T> LerArquivo<T>(string nomeArquivo)
        {
            var pasta = GetPastaConfigurada();
            var caminhoAbsoluto = $"{pasta}\\{nomeArquivo}.json";

            if (!File.Exists(caminhoAbsoluto))
            {
                var arquivo = File.Create(caminhoAbsoluto);
                arquivo.Close();
            }

            string retornoArquivo;

            using (var arquivo = new StreamReader(caminhoAbsoluto))
                retornoArquivo = arquivo.ReadToEnd();

            return JsonConvert.DeserializeObject<List<T>>(retornoArquivo) ?? new List<T>();
        }

        private static string GetPastaConfigurada()
        {
            //Caminho Relativo
            //Caminho Absoluto

            //Arquivo de Configuracao
            var pasta = ConfigurationManager.AppSettings["PastaDataBase"];

            if (string.IsNullOrWhiteSpace(pasta))
                throw new Exception("Pasta do Banco de Dados não configurado");

            if (pasta.EndsWith("\\"))
                pasta = pasta.Remove(pasta.Length - 1);

            //AssemblyExecution
            //var pastaExecutavel = System.Environment.CurrentDirectory;

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            return pasta;
        }
    }
}
