using System;

namespace Exercicios
{
    class Program
    {

        static void Main(string[] args)
        {
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                string menu =
    @"******** EXERCÍCIOS - AULA 06 ********

01 - Cálculo de IRRF.
02 - Imprime a tabuada.
03 - Comparar números.
04 - Pesquisa eleitoral.
";

                Console.WriteLine(menu);
                Console.Write("Escolha uma opção: ");
                string captura = Console.ReadLine();

                Console.WriteLine();

                //encerra o sistema se o usuário digitar texto no lugar de números
                if (!int.TryParse(captura, out var opcao))
                {
                    Console.WriteLine("Você não digitou um número válido. Execute o sistema e tente novamente");
                    Console.ReadKey();
                    return;
                }

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                 /*1.A tabela de aliquota do IRRF foi alterada.
                 Solicite o salário do usuário e retorne para ele o valor que pagará de IRRF de acordo com a nova tabela.
                 *****Tabela
                 De 0 a R$ 4.145,00 - Isento
                 De R$ 4.145,01 a R$ 5.678,34 - 20 %
                 De R$ 5.678,35 a R$ 7.838,21 - 25 %
                 Acima de R$ 7.838,22 - 27,5 % */

                        double irrf = 0;

                        Console.WriteLine("Digite o valor do seu salário atual.");
                        string salariodigitado = Console.ReadLine();

                        if (!double.TryParse(salariodigitado, out var salario))
                        {
                            Console.WriteLine($"'{salariodigitado}' não é um valor inválido.");
                            Console.ReadKey();
                            goto default;
                        }



                        if (salario > 0 && salario <= 4145)
                            Console.WriteLine("Você esta isento");

                        else if (salario > 4145 && salario <= 5678.34)
                        {
                            irrf = salario * 0.2;
                            Console.WriteLine($"O valor do IRRF tributado é de {irrf:c}");
                        }
                        else if (salario > 5678.34 && salario <= 7838.21)
                        {
                            irrf = salario * 0.25;
                            Console.WriteLine($"O valor do IRRF tributado é de {irrf:c}");
                        }
                        else if (salario > 7838.21)
                        {
                            irrf = salario * 0.275;
                            Console.WriteLine($"O valor do IRRF tributado é de {irrf:c}");
                        }
                        Console.ReadKey();
                        break;

                    case 2:
                 //2. Solicite um numero de 1 a 10 ao usuário e calcule a tabuada desse número.
                        Console.WriteLine("Digite um número entre 1 e 10.");
                        string numerodigitado = Console.ReadLine();

                        if (!int.TryParse(numerodigitado, out var numero))
                        {
                            Console.WriteLine($"'{numerodigitado}' não é um número válido.");
                            Console.ReadKey();
                            goto default;
                        }

                        if (numero > 0 && numero < 11)
                        {
                            for (int i = 0; i <= 10; i++)
                                Console.WriteLine($"{numero} x {i} = {numero * i}");
                        }

                        Console.ReadKey();
                        break;

                    case 3:
                        /*3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100, 
                          quantos estão entre 100 e 200 e quantos são maiores que 200.*/

                        int menor100 = 0;
                        int entre100e200 = 0;
                        int maior200 = 0;
                        

                        for (int i = 0; i <=10; i++)
                        {
                            Console.Write("Digite um número: ");
                            string numDigitado = Console.ReadLine();

                            if(!int.TryParse(numDigitado, out var num))
                            {
                                Console.WriteLine($"'{numDigitado}' não é um número válido.");
                                Console.ReadKey();
                                goto default;
                            }

                            if (num < 100)
                                menor100 += 1;
                            else if (num > 100 && num < 201)
                                entre100e200 += 1;
                            else if (num > 200)
                                maior200 += 1;
                        }

                        Console.WriteLine($"Dos números digitados {menor100} números são menores que 100, {entre100e200} estão entre 100 e 200 e {maior200} são maiores que 200.");

                        Console.ReadKey();
                        break;

                    case 4:
                 /*4. Faça um sistema de pesquisa eleitoral para presidente no segundo turno.
                 Requisitos:
                 1. O usuário pode escolher 13 - Haddad / 17- Bolsonaro / 00 - Brancos 
                 2. Qualquer outra escolha anulará o voto na pesquisa
                 3. O usuário poderá ter a escolha de votar quantas vezes ele quiser (simulando várias pessoas votando) ou ver o resultado ou sair;
                 4. O resultado deverá conter Votos Totais, Votos Válidos (Votos excluindos os brancos e nulos). % de votos no Haddad e % de votos do Bolsonaro.
                 5. Depois de ver o resultado o usuário poderá voltar para a "urna" e continuar votando ou sair do sistema.*/

                        break;

                    default:
                        Console.WriteLine("Volte ao menu e tente novamente");
                        Console.ReadKey();
                        break;
                }
            }

            Console.ReadLine();
        }

    }
}
