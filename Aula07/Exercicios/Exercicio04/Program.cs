using System;
using Exercicio04.Helpers;
/*4) Os coelhos se reproduzem todo mês.
Considerando que cada par produz exatamente um par de filhotes cada mês, e cada par de filhotes torna-se fértil depois de exatamente um mês.
Solicite ao usuário quantos pares existem inicialmente e quantos pares ele deseja ter.
Calcule para ele quantos meses são necessários para chegar na quantidade de par de coelho desejado.
OBS: Considere que todos os coelhos iniciais já estão fertil.*/
namespace Exercicio04
{
    class Program
    {
        static string _mensagemInvalida = "Você digitou um número inválido, tente novamente!";
        static int mes;

        static void Main(string[] args)
        {
            int coelhosFerteis = InputHelper.GetInputInt("Informe a quantidade de par(es) de coelho(s) que você possuí: ", _mensagemInvalida);
            int coelhosDesejados = InputHelper.GetInputInt("Informe a quantidade de pares de coelhos você deseja: ", _mensagemInvalida);
            int coelhosInferteis=0;

            while (coelhosFerteis + coelhosInferteis < coelhosDesejados)
            {
                coelhosInferteis = coelhosFerteis;
                coelhosFerteis = coelhosFerteis + coelhosInferteis;
                mes++;
            }

            if(mes > 1)
                Console.WriteLine($"Serão necessários {mes} meses para chegar a quantidade de {coelhosInferteis+coelhosFerteis} pares de coelhos");
            else
                Console.WriteLine($"Será necessário {mes} mês para chegar a quantidade de {coelhosInferteis + coelhosFerteis} pares de coelhos");

            Console.ReadKey();
        }
    }
}
