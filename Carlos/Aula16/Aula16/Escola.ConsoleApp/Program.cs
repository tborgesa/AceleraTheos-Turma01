using System;
using HoristaAlias = Escola.Dominio.Horista;
using EnsinoMedioAlias = Escola.Dominio.EnsinoMedio;
using EnsinoSuperiorAlias = Escola.Dominio.EnsinoSuperior;
using MestradoAlias = Escola.Dominio.Mestrado;
using DoutoradoAlias = Escola.Dominio.Doutorado;
using System.Collections.Generic;
using System.Linq;

namespace Escola.ConsoleApp
{
	public class Program
	{
		/* Use todos os 4 pilares de Orientação a Objeto (herança, polimorfismo, abstração e encapsulamento)
		   Use tambem os padrões de nomenclatura definidas nas aulas
			
		   Considere um sistema para escola:
		   
		    1. Nessa escola existe dois tipos de professores: contratado e horaista.
		    
		    2. O sistema deverá calcular o salário de acordo com o professor:
		    
		    Contratado: Fixo de acordo com a escolaridade
		    Segundo grau: R$ 1.000,00
		    Ensino Superior: R$ 1.800,00
		    Mestrado: R$ 3.000,00
		    Doutorado: R$ 5.000,00
		    
		    Horista: R$ 17,00 por hora trabalhada */

		public static int _codigo;
		public static string _nome;
		public static double _hora;
		public static double _valorSalario;


		static void Main(string[] args)
		{
			while (true)
			{
				int opcao = MenuPrincipal();

				switch (opcao)
				{
					case 1:

						OpcaoHorista();

						break;

					case 2:

						OpcaoEnsinoMedio();

						break;

					case 3:

						OpcaoEnsinoSuperior();

						break;

					case 4:

						OpcaoMestrado();

						break;

					case 5:

						OpcaoDoutorado();

						break;

					case 6:

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
				string menu = @"QUAL PROFESSOR DESEJA CADASTRAR?
01 - Horista
02 - Ensino Médio
03 - Ensino Superior
04 - Mestrado
05 - Doutorado
06 - Sair";
				Console.Clear();
				Console.WriteLine(menu);

				if (int.TryParse(Console.ReadLine(), out int opcao) && opcao >= 1 && opcao <= 6)
					return opcao;
				else
				{
					Console.WriteLine("Digite uma opção válida!");
					Console.ReadKey();
				}
			}
		}

		private static void MenuCadastrarProfessorHorista()
		{
			Console.Clear();

			List<HoristaAlias> horistas = new List<HoristaAlias>();

			HoristaAlias horista = new HoristaAlias(_hora, _codigo, _nome);

			Console.WriteLine("Digite o código:");
			_codigo = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite o nome:");
			_nome = Console.ReadLine();

			Console.WriteLine("Digite a quantidade de horas trabalhadas:");
			_hora = double.Parse(Console.ReadLine());					   	

			horistas.Add(new HoristaAlias(_hora, _codigo, _nome));


			Console.ReadKey();
		}

		private static void ListarProfessorHorista()
		{
			Console.Clear();

			List<HoristaAlias> horistas = new List<HoristaAlias>();

			horistas = horistas.OrderBy(a => a.Codigo).ToList();

			foreach (HoristaAlias horista in horistas)
			{
				Console.WriteLine($"Código: {horista.Codigo} - Nome: {horista.Nome} - Horas: {horista.Hora}");
			}

			Console.ReadKey();
		}


		private static void OpcaoHorista()
		{
			Console.Clear();

			string menu = @"Qual dessas opções deseja?
1 - Cadastrar
2 - Listar
3 - Excluir";

			Console.WriteLine(menu);

			int opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
				case 1:

					MenuCadastrarProfessorHorista();

					break;

				case 2:

					ListarProfessorHorista();

					break;

				case 3:

					break;

				default:

					break;
			}						
		}

		private static void OpcaoEnsinoMedio()
		{
			Console.Clear();

			EnsinoMedioAlias ensinoMedio = new EnsinoMedioAlias(_valorSalario, _codigo, _nome);

			Console.WriteLine($"O salário do professor com ensino médio é de R${ensinoMedio.CalcularSalario():N2}");

			Console.ReadKey();
		}

		private static void OpcaoEnsinoSuperior()
		{
			Console.Clear();

			EnsinoSuperiorAlias ensinoSuperior = new EnsinoSuperiorAlias(_valorSalario, _codigo, _nome);

			Console.WriteLine($"O salário do professor com ensino superior é de R${ensinoSuperior.CalcularSalario():N2}");

			Console.ReadKey();
		}

		private static void OpcaoMestrado()
		{
			Console.Clear();

			MestradoAlias mestrado = new MestradoAlias(_valorSalario, _codigo, _nome);

			Console.WriteLine($"O salário do professor com metrado é de R${mestrado.CalcularSalario():N2}");

			Console.ReadKey();
		}

		private static void OpcaoDoutorado()
		{
			Console.Clear();

			DoutoradoAlias doutorado = new DoutoradoAlias(_valorSalario, _codigo, _nome);

			Console.WriteLine($"O salário do professor com doutorado é de R${doutorado.CalcularSalario():N2}");

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
