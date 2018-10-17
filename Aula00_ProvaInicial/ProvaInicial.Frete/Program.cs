using System;

namespace ProvaInicial.Frete
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Questão 3 (2 pontos)

             Uma transportadora faz o cálculo do frete de cada encomenda de acordo com suas dimensões e peso.
             Porém sempre cobra de seu cliente um valor cheio, sem centavos, de acordo com o código abaixo:
             OBS: As medidas de comprimento devem ser passadas ao método em metros e de peso em Quilograma

            public int CalcularFrete(double altura, double largura, 
            double comprimento, double peso)
            {
                double valorBase = peso;

                if (peso > 1)
                    valorBase = 1 / peso;

                double valorFrete = (altura+largura+comprimento)/valorBase;
    
                return (int) valorFrete;
             }

             Calcule o frete das seguintes encomendas:
 
            Altura: 0,5 m / Largura: 0,4 m / Comprimento: 0,2 m / Peso: 0,5 kg (1 ponto)                                                         
            Altura: 0,7 m / Largura: 0,3 m / Comprimento: 0,9 m / Peso: 3 kg (1 ponto)

             */

            var produto1 = new Produto
            {
                Altura = 0.5,
                Largura = 0.4,
                Comprimento = 0.2,
                Peso = 0.5
            };

            Console.WriteLine(new Frete().CalcularFrete(produto1.Altura, produto1.Largura, produto1.Comprimento, produto1.Peso)); // 2

            var produto2 = new Produto
            {
                Altura = 0.7,
                Largura = 0.3,
                Comprimento = 0.9,
                Peso = 3
            };

            Console.WriteLine(new Frete().CalcularFrete(produto2.Altura, produto2.Largura, produto2.Comprimento, produto2.Peso)); //5
            Console.ReadKey();
        }
    }
}
