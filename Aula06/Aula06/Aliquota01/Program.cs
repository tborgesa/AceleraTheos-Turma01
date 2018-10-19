using System;


namespace Aliquota01
{
    class Program
    {
        static decimal valorRetido = 0.0m;
        static void Main(string[] args)
        {
            CalcularIRRF();
            Console.ReadKey();
        }

        private static void CalcularIRRF()
        {
            Console.WriteLine("Digite o seu salário atual");
            string salario = Console.ReadLine();

            if(!decimal.TryParse(salario, out decimal salarioConvertido))
            {
                Console.WriteLine("Salário inválido, digite novamente");
                return;
            }

            if (salarioConvertido > 0 && salarioConvertido <= 4145.00m)
                Console.WriteLine("Isento de IRRF");
            else if (salarioConvertido >= 4145.01m || salarioConvertido <= 5678.34m)
            {
                valorRetido = salarioConvertido * 0.020m;
                Console.WriteLine($"Valor retido: {valorRetido:c}");
                return;
            }
            else if (salarioConvertido >= 5678.35m || salarioConvertido <= 7838.21m)
            {
                valorRetido = salarioConvertido * 0.025m;
                Console.WriteLine($"Valor retido: {valorRetido:c}");
                return;
            }
            else if (salarioConvertido >= 7838.22m)
            {
                valorRetido = salarioConvertido * 27.5m / 100;
                Console.WriteLine($"Valor retido: {valorRetido:c}");
                return;
            }
            else
                Console.WriteLine("Impossível calcular IRRF.");
        }
    }
}
