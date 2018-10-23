using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. A tabela de aliquota do IRRF foi alterada.
            //Solicite o salário do usuário e retorne para ele o valor que pagará de IRRF de acordo com a nova tabela.
            //Tabela
            //De 0 a R$ 4.145,00 - Isento
            //De R$ 4.145,01 a R$ 5.678,34 - 20 %
            //De R$ 5.678,35 a R$ 7.838,21 - 25 %
            //Acima de R$ 7.838,22 - 27,5 %

            decimal salario;
            Console.WriteLine("Digite seu salario");
            salario = Convert.ToDecimal(Console.ReadLine());


            if (salario>0 && salario<= 4145.00m)
            {
                Console.WriteLine("Não pagará nenhum valor de IRRF");
                
            }

            else if (salario>=4145.01m && salario<=5678.34m)
            {
                Console.WriteLine($"O valor que pagará é : {salario * 0.2m:c2}");
            }

            else if (salario >= 5678.35m && salario <= 7838.21m)
            {
                Console.WriteLine($"O valor que pagará é : {salario * 0.25m:c2}");
            }

            else
            {
                Console.WriteLine($"O valor que pagará é : {salario * 0.275m:c2}");
            }
            Console.ReadKey();



        }



    }
}
