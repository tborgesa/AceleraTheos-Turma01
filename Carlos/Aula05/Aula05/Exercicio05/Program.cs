using System;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5. As transações de cartão do banco de dados armazenam a data e hora da transação.
                  Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é capaz de buscar todas as transações da data solicitada. */

            Console.WriteLine("Digite a data de filtro das transações que deseja buscar:");
            DateTime dataFiltro = DateTime.Parse(Console.ReadLine());

            var dataInicio = dataFiltro;

            DateTime dataFim = dataFiltro.AddDays(1).AddMilliseconds(-1);


            Console.WriteLine($"\nData início do filtro: {dataInicio:dd/MM/yyyy HH:mm:ss}.");
            Console.WriteLine($"Data fim do filtro: {dataFim:dd/MM/yyyy HH:mm:ss}.");


            Console.ReadKey();


        }
    }
}
