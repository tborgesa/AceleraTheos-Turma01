using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. As transações de cartão do banco de dados armazenam a data e hora da transação.
            //Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é capaz de buscar todas as transações da data solicitada.

            Console.WriteLine("Digite a data para filtro das transações:");

            DateTime dataFiltro = DateTime.Parse(Console.ReadLine());

            DateTime dataInicial = dataFiltro.Date;
            DateTime dataFinal = dataInicial.AddDays(1).AddSeconds(-1);

            Console.WriteLine($"A data da inicial do filtro é {dataInicial:dd/MM/yyyy HH:mm:ss} e a data final é {dataFinal:dd/MM/yyyy HH:mm:ss}");
            Console.ReadKey();
        }
    }
}
