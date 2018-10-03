using System;

namespace ProvaInicial.Frete
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Encomenda 1:
            Altura: 0,5 m
            Largura: 0,4 m
            Comprimento: 0,2 m
            Peso: 0,5 kg
            Frete: R$ 2,00
            */

            var produto1 = new Produto
            {
                Altura = 0.5,
                Largura = 0.4,
                Comprimento = 0.2,
                Peso = 0.5
            };

            Console.WriteLine(new Frete().CalcularFrete(produto1.Altura, produto1.Largura, produto1.Comprimento, produto1.Peso));

            /*
            Produto2:
            Altura: 0,7 m
            Largura: 0,3 m
            Comprimento: 0,9 m
            Peso: 3 kg
            Frete: R$ 5,00
            */
            var produto2 = new Produto
            {
                Altura = 0.7,
                Largura = 0.3,
                Comprimento = 0.9,
                Peso = 3
            };

            Console.WriteLine(new Frete().CalcularFrete(produto2.Altura, produto2.Largura, produto2.Comprimento, produto2.Peso));
            Console.ReadKey();
        }
    }
}
