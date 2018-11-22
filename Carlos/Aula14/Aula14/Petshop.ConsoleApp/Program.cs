using System;
using AnimalCachorroAlias = Petshop.Dominio.Cachorro;
using AnimalGatoAlias = Petshop.Dominio.Gato;
using AnimalPeixeAlias = Petshop.Dominio.Peixe;

namespace Petshop.ConsoleApp
{
	public class Program
	{
		/*Use todos os 4 pilares de Orientação a Objeto (herança, polimorfismo, abstração e encapsulamento)
		  Use tambem os padrões de nomenclatura definidas nas aulas
		  
		  Considere um sistema para um petshop:
		  
		  1. Este sistema poderá caadstrar os seguintes tipos de animais: cachorro, gato e peixe.
		  
		  2. O sistema deverá calcular o valor do serviço de limpeza de cada animal, depende de cada tipo
		  Gato: Peso x 1.6
		  Cachorro: Peso x 2
		  Peixe: (altura x largura x comprimento) (dimensões do aquario em litros) x 1.5
		  
		  3. Não existe nenhuma valor possível para um animal genéríco.*/

		static void Main(string[] args)
		{
			while (true)
			{
				int opcao = MenuPrincipal();

				switch (opcao)
				{
					case 1:

                        OpcaoCachorro();

                        break;

					case 2:

                        OpcaoGato();
						
						break;

					case 3:

                        OpcaoPeixe();

						break;

					case 4:

                        OpcaoSair();

						return;

					default:
						break;
				}
			}
		}

		private static int MenuPrincipal()
		{
			while (true)
			{
				string menu = @"QUAL ANIMAL DESEJA REALIZAR O SERVIÇO DE LIMPEZA?
01 - Cachorro
02 - Gato
03 - Peixe
04 - Sair";
				Console.Clear();
				Console.WriteLine(menu);

				if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 4)
					return opcao;
				else
				{
					Console.WriteLine("Digite uma opção válida!");
					Console.ReadKey();
				}
			}
		}

        private static void OpcaoCachorro()
        {
            Console.Clear();

            AnimalCachorroAlias cachorro = new AnimalCachorroAlias(null, 0);

            Console.WriteLine($"Digite o nome do cachorro:");
            cachorro.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o peso do cachorro:");
            cachorro.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da limpeza do {cachorro.Nome} é R${cachorro.CalcularValorServico():N2}");

            Console.ReadKey();
        }

        private static void OpcaoGato()
        {
            Console.Clear();

            AnimalGatoAlias gato = new AnimalGatoAlias(null, 0);

            Console.WriteLine($"Digite o nome do gato:");
            gato.Nome = Console.ReadLine();

            Console.WriteLine($"Digite o peso do gato:");
            gato.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor da limpeza do {gato.Nome} é R${gato.CalcularValorServico():N2}");

            Console.ReadKey();
        }

        private static void OpcaoPeixe()
        {
            Console.Clear();

            AnimalPeixeAlias peixe = new AnimalPeixeAlias(0, 0, 0);

            Console.WriteLine($"Digite a altura do aquário em centímetros:");
            peixe.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a largura do aquário em centímetros:");
            peixe.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a comprimento do aquário em centímetros:");
            peixe.Comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor de limpeza do aquário é R${peixe.CalcularValorServico():N2}");

            Console.ReadKey();
        }

        private static void OpcaoSair()
        {
            Console.Clear();
            Console.WriteLine("Você escolheu sair!");
            Console.ReadKey();
        }
    }
}