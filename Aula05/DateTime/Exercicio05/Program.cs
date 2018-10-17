using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 5. As transações de cartão do banco de dados armazenam a data e hora da transação.
	Solicite a data de filtro para o usuário e retorno a data de inicio e data de fim que é capaz de buscar todas as transações da data solicitada.*/
namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data do para o filtro:");
            var use = Console.ReadLine();

            DateTime data = DateTime.Parse(use);
            Console.WriteLine($"O periodo incial e de {(data.AddMinutes(1)):dd/MM/yyyy HH:mm}");
            Console.WriteLine($"O periodo final e de {(data.AddDays(1).AddMilliseconds(-1)):dd/MM/yyyy HH:mm}");

            //Boa praticas? fazer os processos antes do retorno ou no retorno?



            Console.ReadKey();
        }
    }
}
