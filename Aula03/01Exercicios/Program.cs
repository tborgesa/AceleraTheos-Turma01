using System;
/*EXERCICIOS:
Todos os exercicios devem ser solicitado a entrada de dados ao usuario e retornar a saida via Console. */

namespace _01Exercicios
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("**** Escolha a opção desejada *****");
            Console.WriteLine("1. Para calcular o volume de uma caixa;");
            Console.WriteLine("2. Converter a temperatura de graus Fahrenheit para graus Celsius.");
            Console.WriteLine("3. Calcular o consumo de combustivel numa determinada distancia.");
            Console.WriteLine("4. Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.");
            Console.WriteLine("5. Calcular o reajuste de 5% sobre o salário.");

            Console.WriteLine();
            Console.Write("Digite uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (opcao > 6)
            {
                Console.WriteLine("Você diitou uma opção inválida. O programa será encerrado");
                Console.ReadKey(); 
            }

            else
            {
                switch (opcao)
                {

                    case 1:
                        //1.Calcular o volume de uma caixa retangular. *** (volume = altura*largura*profundidade)
                        Console.WriteLine("Digite a altura da caixa:");
                        double alturaCaixa = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a largura da caixa:");
                        double larguraCaixa = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite a profundidade da caixa:");
                        double profundidadeCaixa = Convert.ToDouble(Console.ReadLine());

                        double volume = alturaCaixa * larguraCaixa * profundidadeCaixa;
                        Console.WriteLine($"O volume da caixa é {Math.Round(volume, 2)}.");

                        Console.ReadKey();

                        break;

                    case 2:
                        //2. Converter a temperatura em graus Fahrenheit para graus Celsius. *** (°C = (°F − 32) ÷ 1, 8)
                        Console.WriteLine("Informe a temperatura em °F");
                        double temperaturaF = Convert.ToDouble(Console.ReadLine());

                        double temperaturaC = (temperaturaF - 32) / 1.8;
                        Console.WriteLine($"{Math.Round(temperaturaF, 2)}°F é igual a {Math.Round(temperaturaC, 1)}°C.");

                        Console.ReadKey();

                        break;


                    case 3:
                        /*3. Calcular o consumo de combustivel numa determinada distancia. (Km/l)
                             1. Solicitar Kilometragem inicial.
                             2. Solicitar Kilometragem final.
                             3. Solicitar quantidade de litros gasto.
                             OBS: Deve ser considerado apenas a parte inteira do valor.*/

                        Console.WriteLine("Informe a quilometragem inicial (km)");
                        int kminicial = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quilometragem final (km)");
                        int kmfinal = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de combustível utilizado em litros");
                        int combustivel = Convert.ToInt32(Console.ReadLine());

                        int totalGasto = (kmfinal - kminicial) / combustivel;
                        Console.WriteLine($"Foram gastos {totalGasto} litros de combustível no percurso informado.");
                        Console.ReadKey();

                        break;

                    case 4:
                        /*4.Calcular a media final de um aluno, sabendo que ele realizou quatro provas no ano.
                        1.Solicitar a nota de cada prova.
                        2.Solicitar o nome do aluno para apresentar na mensagem final.
                        OBS: Deve ser arredondado (Math.Round) e apresentar apenas a parte inteira da nota.*/
                        Console.WriteLine("Informe o nome do aluno");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota da primeira prova");
                        double nota1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a nota da primeira prova");
                        double nota2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a nota da primeira prova");
                        double nota3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a nota da primeira prova");
                        double nota4 = Convert.ToInt32(Console.ReadLine());

                        double media = (nota1 + nota2 + nota3 + nota4) / 4;

                        Console.WriteLine($"A média do aluno(a) {nome} foi de {Math.Round(media)}");
                        Console.ReadKey();
                        break;

                    case 5:
                        //5. Calcule o novo salario de um funcionario, sabendo que o reajuste dado para todos na empresa foi de 5%.
                        Console.WriteLine("Qual o nome do funcionário?");
                        string funcionario = Console.ReadLine();

                        Console.WriteLine($"Qual é o salário atual do(a) {funcionario}");
                        double salario = Convert.ToDouble(Console.ReadLine());

                        double ajuste = (salario * 5) / 100;
                        salario = salario + ajuste;

                        Console.WriteLine($"O salário do(a) {funcionario} recebeu um ajuste de R${Math.Round(ajuste, 2)} e agora corresponde a R${Math.Round(salario, 2)}");
                        Console.ReadKey();

                        break;

                }

                Console.WriteLine();
                Console.WriteLine("***Obrigada por utilizar este programa.***");
                Console.ReadKey();
            }
        }
    }
}
