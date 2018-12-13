using System;
using ClienteAlias = UaiQueijos.Dominio.Cliente.Cliente;
using FornecedorAlias = UaiQueijos.Dominio.Fornecedor.Fornecedor;
using FuncionarioAlias = UaiQueijos.Dominio.Funcionario.Funcionario;
using ClienteGoldAlias = UaiQueijos.Dominio.Cliente.ClienteGold;
using ClienteSilverAlias = UaiQueijos.Dominio.Cliente.ClienteSilver;
using PessoaAlias = UaiQueijos.Dominio.Pessoa;
using System.Text;

namespace UaiQueijos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EnviarTodosEmails();
            }
            catch (Exception ex)
            {
                Console.WriteLine(GravaLog(ex));
            }

            Console.ReadKey();
        }

        private static string GravaLog(Exception ex)
        {
            Exception excecao = ex;
            StringBuilder log = new StringBuilder();

            int numeroErro = new Random().Next();

            log.AppendLine($"Segue detalhes do erro {numeroErro}:");

            while (excecao != null)
            {
                var mensagem = excecao.Message;
                string stackTrace = excecao.StackTrace;

                log.AppendLine($"Mensagem do Erro: {mensagem}");
                log.AppendLine($"Detalhes do Erro: {stackTrace}");

                log.AppendLine($"*************************************");
                excecao = excecao.InnerException;
            }

            Console.WriteLine(log.ToString());

            return $"Ocorreu um erro inesperado no sistema. Utilize o codigo {numeroErro} para ligar para o suporte.";
        }

        private static void EnviarTodosEmails()
        {
            try
            {
                FornecedorAlias fornecedor = new FornecedorAlias(
                new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago fornecedor","Thiago");

                EnviarEmail(fornecedor);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar email para o cliente pobre.", ex);
            }

            ClienteAlias cliente = new ClienteAlias(
                new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago cliente pobre");

            EnviarEmail(cliente);

            ClienteSilverAlias clienteSilver = new ClienteSilverAlias(new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago cliente Silver");

            EnviarEmail(clienteSilver);

            ClienteGoldAlias clienteGold = new ClienteGoldAlias(new DateTime(1987, 7, 8),
                "07346153618",
                "Thiago cliente Gold");

            EnviarEmail(clienteGold);

            

            FuncionarioAlias funcionario = new FuncionarioAlias(
               new DateTime(1987, 7, 8),
               "07346153618",
               "Thiago funcionario", "Thiago");

            EnviarEmail(funcionario);
        }

        private static void EnviarEmail(PessoaAlias pessoa)
        {
            string assunto = pessoa.CriarEmail();
            Console.WriteLine($"Email enviado para {pessoa.Nome}: {assunto}");
        }

    }
}
