using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. As transações de cartão do banco de dados armazenam a data e hora da transação.
            //Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é capaz de buscar todas as transações da data solicitada.

            Console.WriteLine("Por favor, informe a data de filtro.");
            DateTime dataFiltro = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine($"Inicio da data informada: {dataFiltro: dd/MM/yyyy} 00:00:00, e o fim da data informada: {dataFiltro: dd/MM/yyyy} 23:59:59.");
            

            Console.ReadKey();
        }
    }
}
