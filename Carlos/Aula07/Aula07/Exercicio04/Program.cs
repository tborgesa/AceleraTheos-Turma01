using System;

namespace Exercicio04
{
    class Program
    {
        static int _coelhosFerteis = 0,
                   _coelhosDesejados = 0,
                   _coelhosInferteis = 0,
                    _mes = 0;

        static void Main(string[] args)
        {
            /*
             4) Os coelhos se reproduzem todo mês.
                Considerando que cada par produz exatamente um par de filhotes cada mês, e cada par de filhotes torna-se fértil depois de exatamente um mês.
                Solicite ao usuário quantos pares existem inicialmente e quantos pares ele deseja ter.
                Calcule para ele quantos meses são necessários para chegar na quantidade de par de coelho desejado.
                OBS: Considere que todos os coelhos iniciais já estão fertil. 
             */
            Console.WriteLine("Digite quantos pares de coelhos existem inicialmente:");
            _coelhosFerteis = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite quantos pares de coelhos deseja ter:");
            _coelhosDesejados = int.Parse(Console.ReadLine());

            if (_coelhosDesejados <= _coelhosFerteis)
            {
                Console.WriteLine("Não é necessário reprodução, pois você já tem os pares desejados.");
            }

            while (_coelhosFerteis + _coelhosInferteis < _coelhosDesejados)
            {
                _mes++;
                int ferteisMesAnterior = _coelhosFerteis;
                int inferteisMesAnterior = _coelhosInferteis;
                _coelhosInferteis = ferteisMesAnterior;
                _coelhosFerteis = ferteisMesAnterior + inferteisMesAnterior;
                
            }

            Console.WriteLine($"\n\nSão necessários {_mes} meses para chegar na quantidade desejada de coelhos.");

            Console.ReadKey();

        }
    }
}
