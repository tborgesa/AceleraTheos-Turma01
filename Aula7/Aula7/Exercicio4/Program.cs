using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos pares de coelhos você tem.");
            int numeroParesCoelhosFerteis = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe quantos pares de coelhos você deseja ter.");
            int numeroDesejavelParesCoelhos = int.Parse(Console.ReadLine());

            int coelhosInferteis = 0;
            int mes = 0;

            if(numeroDesejavelParesCoelhos <= numeroParesCoelhosFerteis)
                Console.WriteLine("Não é necessária a reprodução.");

            while (numeroParesCoelhosFerteis + coelhosInferteis < numeroDesejavelParesCoelhos)
            {
                mes ++;
                int ferteisMesAnterior = numeroParesCoelhosFerteis;
                int inferteisMesAnterior = coelhosInferteis;
                coelhosInferteis = ferteisMesAnterior;
                numeroParesCoelhosFerteis = ferteisMesAnterior + inferteisMesAnterior;

            }

            Console.WriteLine($"Em {mes} mes(es), a quantidade desejada será alçançada.");

            Console.ReadKey();



        }
    }
}
