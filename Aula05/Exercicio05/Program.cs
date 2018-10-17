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

            DateTime dataHoraTransacao = DateTime.Now;
            DateTime dataInicial = new DateTime();
            DateTime dataFinal = new DateTime();

            Console.WriteLine($"Digite a data inicial para a pesquisa");
            dataInicial = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a data final para a pesquisa");
            dataFinal = DateTime.Parse(Console.ReadLine());

            Console.WriteLine($"{dataHoraTransacao}");

            Console.ReadKey();
        }
    }
}
