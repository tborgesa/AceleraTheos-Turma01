using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.O fechamento contábil anual sempre acontece no ultimo dia do ano.
            //Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.

            Console.WriteLine("Digite o ano do fechamento contábil");

            int anoFechamento;

            anoFechamento = int.Parse(Console.ReadLine());

            DateTime dataFechamento = new DateTime(anoFechamento,12,31);
            DateTime dataFechamento2 = new DateTime(anoFechamento,12,DateTime.DaysInMonth(anoFechamento,12));

            Console.Clear();

            Console.WriteLine($"{dataFechamento:dd/MM/yyyy}");
            Console.WriteLine($"{dataFechamento2:dd/MM/yyyy}");


            Console.ReadKey();
            

        }
    }
}
