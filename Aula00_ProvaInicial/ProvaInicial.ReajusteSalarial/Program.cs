using System;

namespace ProvaInicial.ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            var salarioJose = 900;
            var salarioMaria = 2200;
            var salarioJoão = 3852;
            var salarioJoaquina = 4500;

            Console.WriteLine(new Salario().ReajusteSalario(salarioJose)); // 1080
            Console.WriteLine(new Salario().ReajusteSalario(salarioMaria)); // 2530
            Console.WriteLine(new Salario().ReajusteSalario(salarioJoão)); //4044,6
            Console.WriteLine(new Salario().ReajusteSalario(salarioJoaquina)); //4501
            Console.ReadKey();

        }
    }
}
