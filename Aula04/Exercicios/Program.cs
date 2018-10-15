using System;
/*EXERCICIOS:
Todos os exercicios devem ser solicitado a entrada de dados ao usuario e retornar a saida via Console. */
namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** ESCOLHA UMA OPÇÃO *****");

            Console.WriteLine("1. Exercício 1: Passaportes.");
            Console.WriteLine("2. Exercício 2: Endereços.");
            Console.WriteLine("3. Exercicío 3: Temperatura.");
            Console.WriteLine("4. Exercício 4: Salário");
            Console.WriteLine("5. Exercício 5: Filme, livro e hobby.");
            Console.WriteLine();

            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                /*1.O sistema de passorte sempre obriga que o ultimo nome sempre venha primeiro nos documentos.
                Solicite o nome completo do usuario e apresente para ele "UltimoNome, PrimeiroNome" como é apresentado no passaporte.*/
                case 1:

                    Console.WriteLine("Digite seu nome completo:");
                    string nomedigitado = Console.ReadLine();
                    string[] nomecompleto = nomedigitado.Split(' '); //separa a strin em array, delimitando por espaço
                    int i = nomecompleto.Length; //verificando o tamanho do array
                    if (i < 2)
                    {
                        Console.WriteLine("Você digitou apenas um nome.");
                        Console.WriteLine($"Nome do Passaporte: {nomecompleto[0].ToUpper()}");
                    }
                    else
                    {
                        Console.WriteLine($"Nome do Passaporte: {nomecompleto[i - 1].ToUpper()},{nomecompleto[0]}");
                    }
                    break;
                case 2:
                    //2.Peça para o usuário digitar o endereço completo(Rua, Bairro e Cidade) separados por ',' e apresente para ele cada item separado.
                    Console.WriteLine("Digite seu endereço e separado por vírgula como no exemplo: Nome da rua, Nome do Bairro, Nome da Cidade:");
                    string enderecodigitado = Console.ReadLine();
                    string[] endereco = enderecodigitado.Split(',');

                    for(int y = 0; y < endereco.Length; y++)
                    {
                        Console.WriteLine(endereco[y].Trim());
                    }
                    break;
                case 3:
                    //3.Volte ao exercicio 2 da aula anterior e formate a temperatura apresentando sempre 2 casas decimais.
                    Console.WriteLine("Informe a temperatura em °F");

                    double temperaturaF = Convert.ToDouble(Console.ReadLine());
                    double temperaturaC = (temperaturaF - 32) / 1.8;

                    Console.WriteLine($"{tempF.ToString("n2", new CultureInfo("en-us"))}°F equivale a {tempC.ToString("n2", new CultureInfo("en-us"))}°C");

                    break;
                case 4:
                    // 4.Volte ao exercicio 5 da aula anterior e formate o salário apresentando sempre 2 casas decimai
                    Console.WriteLine("Qual o nome do funcionário?");
                    string funcionario = Console.ReadLine();

                    Console.WriteLine($"Qual é o salário atual do(a) {funcionario}");
                    double salario = Convert.ToDouble(Console.ReadLine());

                    double ajuste = (salario * 5) / 100;
                    salario = salario + ajuste;

                    Console.WriteLine($"O salário do(a) {funcionario} recebeu um ajuste de {ajuste.ToString("c")} e agora corresponde a {salario.ToString("c")}");

                    break;
                case 5:
                    /* 5.Solicite ao usuário: -Filme Favorito, -Livro de Cabeceira, -Hobby Preferido
                    Crie uma string que junte todas as informações e apresente para o usuário, colocando a identificação sempre maiuscula
                    Ex: FILME: Esqueceram de mim 2, LIBRO: Biblia, Hobby: Dormir*/
                    Console.WriteLine("Qual é seu filme favorito?");
                    string filme = Console.ReadLine().ToUpper();
                    
                    Console.WriteLine("Qual é seu livro de Cabeceira?");
                    string livro = Console.ReadLine().ToUpper();

                    Console.WriteLine("Qual é seu hobby predileto?");
                    string hobby = Console.ReadLine().ToUpper();

                    Console.WriteLine($"FILME: {filme}");
                    Console.WriteLine($"LIVRO: {livro}");
                    Console.WriteLine($"HOBBY: {hobby}");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("FIM");
            Console.Read();
            
            }
        }
}
