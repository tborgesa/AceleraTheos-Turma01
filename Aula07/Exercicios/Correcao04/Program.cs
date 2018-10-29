using System;
using Correcao04.Helpers;

namespace Correcao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reprodução de Coelhos");

            int coelhosFerteis = InputHelper.GetInputInt("Informe a quantidade de coelhos inciais: ", "Digite um número válido");
            int coelhosDesejados = InputHelper.GetInputInt("Informe a quantidade de coelhos desejados: ", "Digite um número válido");
            int coelhosInferteis = 0;
            int coelhosTotais = coelhosFerteis + coelhosInferteis;
            int mes = 0;

            if (coelhosDesejados <= coelhosFerteis)
            {
                Console.WriteLine("Não é necessário reprodução, pois você já tem os coelhos desejados");
                Console.ReadKey();
            }

            while (coelhosFerteis + coelhosInferteis < coelhosDesejados)
            {
                mes++;
                int ferteisMesAnterior = coelhosFerteis;
                int inferteisMesAnterior = coelhosInferteis;
                coelhosInferteis = ferteisMesAnterior;
                coelhosFerteis = ferteisMesAnterior + coelhosInferteis;
            }

            Console.WriteLine($"Você terá que esperar {mes} mes(es) para obter a quantidade desejada");
            Console.ReadKey();
        }
    }
}
