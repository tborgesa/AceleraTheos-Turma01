using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.As transações de cartão do banco de dados armazenam a data e hora da transação.
            //Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é 
            //capaz de buscar todas as transações da data solicitada.

           
            DateTime dataPesquisa = new DateTime();

            Console.WriteLine($"Digite a data inicial para a pesquisa");
            dataPesquisa = DateTime.Parse(Console.ReadLine());

            DateTime dataInicial = dataPesquisa;
            DateTime dataFinal = dataPesquisa.AddHours(24).AddMilliseconds(-1);

            Console.WriteLine($"{dataInicial:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"{dataFinal:dd/MM/yyyy HH:mm:ss}");

            Console.ReadKey();
        }
    }
}
