using System.Configuration;
using System;
using System.IO;

namespace UaiQueijos.Comum.Helpers
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