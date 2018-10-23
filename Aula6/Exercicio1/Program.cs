using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. A tabela de aliquota do IRRF foi alterada.
            //Solicite o salário do usuário e retorne para ele o valor que pagará de IRRF de acordo com a nova tabela.

                                        /*Tabela
                                De 0 a R$ 4.145,00 - Isento
                                De R$ 4.145,01 a R$ 5.678,34 - 20 %
                                De R$ 5.678,35 a R$ 7.838,21 - 25 %
                                Acima de R$ 7.838,22 - 27,5 %*/

            Console.WriteLine("Por favor, informe seu nome.");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome}, informe seu salario para prosseguir.");
            string salario = Console.ReadLine();


            if (!double.TryParse(salario, out var salarioUsuario))
            {
                Console.WriteLine("por favor, informe um salario válido!");
                Console.ReadKey();
                return;
            }


            if (salarioUsuario >=0 && salarioUsuario <= 4145)
                Console.WriteLine("Você está livre deste imposto, amém!");
            else if (salarioUsuario >= 4145.01 && salarioUsuario <= 5678.34)
            {
                double imposto = salarioUsuario * 0.20 ;
                double novoSalario = salarioUsuario - imposto;
                Console.WriteLine($"Seu salario passa a ser de {novoSalario:n2}");
            }
            else if (salarioUsuario >= 5678.35 && salarioUsuario <= 7838.21)
            {
                double imposto = salarioUsuario * 0.25 ;
                double novoSalario = salarioUsuario - imposto;
                Console.WriteLine($"Seu salario passa a ser de {novoSalario:n2}");
            }
            else if (salarioUsuario >= 7838.22 )
            {
                double imposto = salarioUsuario * 0.275 ;
                double novoSalario = salarioUsuario - imposto;
                Console.WriteLine($"Seu salario passa a ser de {novoSalario:n2}");
            }
           


            Console.ReadKey();
        }
    }
}
