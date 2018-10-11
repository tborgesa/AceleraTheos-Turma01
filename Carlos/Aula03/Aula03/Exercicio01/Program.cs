using System;

namespace Exercicio01
{
    class Program
    {
        public class Menu
        {
            public string Tecla { get; set; }
            public int Opcao { get; set; }

            public void MenuMenssagem()
            {
                Console.Clear();

                Console.WriteLine("********************************************************************************************************************");
                Console.WriteLine("CALCULOS\n");
                Console.WriteLine("(1) - Calcular o volume de uma caixa retangular.");
                Console.WriteLine("(2) - Converter a temperatura em graus Fahrenheit para graus Celsius.");
                Console.WriteLine("(3) - Converter a temperatura em graus Celsius para graus Fahrenheit.");
                Console.WriteLine("(4) - Calcular o consumo de combustivel numa determinada distancia. (Km/l).");
                Console.WriteLine("(5) - Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.");
                Console.WriteLine("(6) - Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.");
                Console.WriteLine("(7) - SAIR");
                Console.WriteLine("********************************************************************************************************************");

                Console.WriteLine("\nDigite uma opção de 1 a 7 para escolher o calculo desejado:");
                Opcao = int.Parse(Console.ReadLine());

            }

            public void MenuMenssagemSair()
            {
                Console.WriteLine("\n\nDigite M e tecle ENTER para voltar ao menu de opções\n\nOu...\n\nTecle ENTER para sair");
                Tecla = Console.ReadLine();

                if (Tecla.ToUpper() == "M")
                {
                    MenuMenssagem();
                }
            }
        }

        static void Main(string[] args)
        {
            var objMenu = new Menu();

            objMenu.MenuMenssagem();


            switch (objMenu.Opcao)
            {
                case 1:

                    //1. Calcular o volume de uma caixa retangular.

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(1) - Calcular o volume de uma caixa retangular.");

                    Console.WriteLine("\nInforme a altura da caixa:");
                    decimal alturaCaixa = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme a largura da caixa:");
                    decimal larguraCaixa = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme a comprimento da caixa:");
                    decimal comprimentoCaixa = decimal.Parse(Console.ReadLine());

                    decimal volumeCaixa = (alturaCaixa * larguraCaixa * comprimentoCaixa) * 1000;

                    Console.WriteLine($"\nO volume da caixa é {volumeCaixa} L.");

                    objMenu.MenuMenssagemSair();

                    break;

                case 2:

                    //2 - Converter a temperatura em graus Fahrenheit para graus Celsius.

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(2) - Converter a temperatura em graus Fahrenheit para graus Celsius.");

                    Console.WriteLine("\nInforme a temperatura em Fahrenheit:");
                    float temperaturaF = float.Parse(Console.ReadLine());

                    var temperaturaC = ((temperaturaF - 32) / 1.8);

                    Console.WriteLine($"\nA temperatura em Celsius é {temperaturaC}.");

                    objMenu.MenuMenssagemSair();

                    break;

                case 3:

                    //3 - Converter a temperatura em graus Celsius para graus Fahrenheit.

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(3) - Converter a temperatura em graus Celsius para graus Fahrenheit.");

                    Console.WriteLine("\nInforme a temperatura em Celsius:");
                    float temperaturaC2 = float.Parse(Console.ReadLine());

                    var temperaturaF2 = ((temperaturaC2 * 1.8) + 32);

                    Console.WriteLine($"\nA temperatura em Fahrenheit é {temperaturaF2}.");

                    objMenu.MenuMenssagemSair();

                    break;


                case 4:

                    //4 - Calcular o consumo de combustivel numa determinada distancia. (Km/l).

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(4) - Calcular o consumo de combustivel numa determinada distancia. (Km/l).");

                    Console.WriteLine("\nInforme a KM inicial:");
                    decimal kmInicial = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme a KM final:");
                    decimal kmFinal = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme a quantidade de litros:");
                    decimal qntLitros = decimal.Parse(Console.ReadLine());

                    decimal consumoCombustivel = (kmFinal - kmInicial) / qntLitros;
                    int consumoCombustivelInteiro = (int)consumoCombustivel;

                    Console.WriteLine($"\nO consumo de combustível foi de: {consumoCombustivelInteiro} km/l.");

                    objMenu.MenuMenssagemSair();

                    break;

                case 5:

                    //Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(5) - Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.");

                    Console.WriteLine("\nInforme o nome do aluno:");
                    string nomeAluno = Console.ReadLine();

                    Console.WriteLine("\nInforme 1º nota:");
                    decimal nota01 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme 2º nota:");
                    decimal nota02 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme 3º nota:");
                    decimal nota03 = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme 4º nota:");
                    decimal nota04 = decimal.Parse(Console.ReadLine());

                    var mediaFinal = (nota01 + nota02 + nota03 + nota04) / 4;

                    decimal arredondamentoMedia = Math.Round(mediaFinal);

                    Console.WriteLine($"\nO aluno {nomeAluno}, obteve a média final de {arredondamentoMedia}.");

                    objMenu.MenuMenssagemSair();

                    break;

                case 6:

                    //Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.

                    Console.Clear();

                    Console.WriteLine("OPÇÃO ESCOLHIDA:\n(6) - Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.");

                    Console.WriteLine("\nInforme o salário do funcionário:");
                    decimal salarioFuncionario = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("\nInforme o percentual para ser reajustado:");
                    decimal percentualReajuste = decimal.Parse(Console.ReadLine());

                    var valorReajustado = salarioFuncionario + (salarioFuncionario * (percentualReajuste / 100));

                    Console.WriteLine($"\nO valor do salário com reajuste é de R${valorReajustado}.");

                    objMenu.MenuMenssagemSair();

                    break;

                case 7:

                    break;

                default:

                    Console.Clear();

                    Console.WriteLine("Opção inválida!");

                    objMenu.MenuMenssagemSair();

                    break;
            }
        }
    }
}