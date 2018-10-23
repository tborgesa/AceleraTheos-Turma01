using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. A tabela de aliquota do IRRF foi alterada.
            Solicite o salário do usuário e retorne para ele o valor que pagará de IRRF de acordo com a nova tabela.

            Tabela
            De 0 a R$ 4.145,00 - Isento
            De R$ 4.145,01 a R$ 5.678,34 - 20 %
            De R$ 5.678,35 a R$ 7.838,21 - 25 %
            Acima de R$ 7.838,22 - 27,5 % */

            Console.WriteLine("Digite o seu salário:");
            decimal salario = decimal.Parse(Console.ReadLine());
            

            if (salario >= 0 && salario <= 4145)
            {
                Console.WriteLine("Salário até R$4.145,00 é isento de pagamento de IRRF!");
            }
            else if (salario >= 4145.01m && salario <= 5678.34m)
            {
                salario = salario * 0.20m;

                Console.WriteLine($"Salário de R$ 4.145,01 a R$ 5.678,34 tem 20% e vai pagar: {salario}");
            }
            else if (salario >= 5678.35m && salario <= 7838.21m)
            {
                salario = salario * 0.25m;

                Console.WriteLine($"Salário de R$5.678,35 a R$7.838,21 tem 25% e vai pagar: {salario}");
            }
            else if (salario >= 7838.22m)
            {
                salario = salario * 0.275m;

                Console.WriteLine($"Salário acima de R$7.838,22 tem 27,5% e vai pagar: {salario}");
            }

            Console.ReadKey();                
        }
    }
}
