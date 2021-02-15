using System;
using System.IO;
using System.Configuration;

namespace PetShop.Comum.Helpers
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

        private static string GetPastaConfigurada()
        {
            var pasta = ConfigurationManager.AppSettings["PastaDataBase"];

            if (string.IsNullOrEmpty(pasta))
                throw new Exception("Pasta do Banco de Dados não configurado.");

            if (pasta.EndsWith("\\"))
                pasta = pasta.Remove(pasta.Length - 1);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            return pasta;
        }

        public  static string LerArquivo(string nomeArquivo)
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
    }
}