using System;

namespace ProvaInicial.Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Questão 5 (2 pontos)

            Alguns clientes das Theos solicitaram que fosse colocada uma calculadora no sistema “Eclesial” e você ficou responsável por fazer as operações internas na calculadora. Implemente uma classe com as seguintes características:

            Classe Operacao. (0,5 ponto)
            Propriedades Fator1 e Fator2. (0,5 ponto)
            Construtor que receba os valores das propriedades acima. (0,5 ponto)
            Método que realiza as soma dos dois fatores da classe e retorna o valor. (0,5 ponto)

             */

            var operacao1 = new Operacao(4, 2);
            Console.WriteLine($"Soma: {operacao1.Soma()}");
            Console.ReadKey();
        }
    }
}
