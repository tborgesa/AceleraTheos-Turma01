using Refatoracao.Helpers;
using System;


namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reprodução de coelhos");

            int coelhosFerteis = InputHelper.GetInputInt("Informe a quantidade de coelhos iniciais: ", "Digite um número válido");
            int coelhosDesejados = InputHelper.GetInputInt("Informe a quantidade de coelhos desejados: ", "Digite um número válido");
            int coelhosInferteis = 0;
            int mes = 0;

            if (coelhosDesejados <= coelhosFerteis)
                InputHelper.MensagemUsuario("Não é necessário reprodução, pois você já tem os coelhos desejados");

            while(coelhosFerteis + coelhosInferteis < coelhosDesejados)
            {
                mes++;
                int ferteisMesAnterior = coelhosFerteis;
                int inferteisMesAnterior = coelhosFerteis;
            }
        }
    }
}
