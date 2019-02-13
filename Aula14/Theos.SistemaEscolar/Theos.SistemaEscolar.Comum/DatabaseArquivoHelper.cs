using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using Newtonsoft.Json;


namespace Theos.SistemaEscolar.Comum
{
    public static class DatabaseArquivoHelper
    {

        public static void GravaArquivo(string conteudo, string nomeArquivo)
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
            //Arquivo config

            var pasta = ConfigurationManager.AppSettings["PastaDataBase"];

            if (string.IsNullOrWhiteSpace(pasta))
                throw new Exception("Pasta do banco de dados não configurada");

            if (pasta.EndsWith("\\"))
                pasta = pasta.Remove(pasta.Length - 1);

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            return pasta;
        }
    }
}
