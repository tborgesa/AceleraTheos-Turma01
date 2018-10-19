using System;


namespace ControleFluxo
{
    class Program
    {
        //field (variável de classe) inicia-se com "_"
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";

        static void Main(string[] args)
        {
            //ExemploIf();
            //ExemploIfElse();
            //ExemploIfElseIf();
            //ExemploFor();
            //ExemploWhile();
            ExemploSwitch();

            Console.ReadKey();
        }

        private static void ExemploIf()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalido);
        }

        private static void ExemploIfElse()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalido);
            else
                Console.WriteLine($"Seja bem-vindo(a), {nome}");
        }

        private static void ExemploIfElseIf()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            DateTime agora = DateTime.Now;

            if (string.IsNullOrWhiteSpace(nome))
                Console.WriteLine(_mensagemInvalido);

            else if (agora.Hour > 6 && agora.Hour < 12)
                Console.WriteLine($"Bom dia, {nome}");

            else if (agora.Hour >= 12 && agora.Hour < 18)
                Console.WriteLine($"Boa tarde, {nome}");

            else
                Console.WriteLine($"Boa Noite, {nome}");
        }

        private static void ExemploFor()
        {
            Console.WriteLine("Digite um número entre 10 e 20:");
            string numeroDigitado = Console.ReadLine();

            if (!int.TryParse(numeroDigitado, out var numero)) //o TryParse tenta converter o vlr recebido em int. o out var cria a váriavel onde será armazenado o vlr convertido
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            else if (numero < 10 || numero > 20)
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            Console.WriteLine("Imprimindo os números pares");

            for (int i = numero; i >= 0; i--)
            {
                if (i == numero / 2)
                    //continue; //para a atual interação do for;
                    break; //para a execução toda do for e continua a execução do sistema;

                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }

        private static void ExemploWhile()
        {
            Console.WriteLine("Digite um número entre 10 e 20:");
            string numeroDigitado = Console.ReadLine();

            if (!int.TryParse(numeroDigitado, out var numero)) //o TryParse tenta converter o vlr recebido em int. o out var cria a váriavel onde será armazenado o vlr convertido
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            else if (numero < 10 || numero > 20)
            {
                Console.WriteLine(_mensagemInvalido);
                return;
            }

            Console.WriteLine("Imprimindo os números pares");
            int numeroinicial = numero;

            while (numeroinicial >= 0)
            {
                if (numeroinicial == numero / 2)
                {
                    numeroinicial--;
                    continue;
                }
                if (numeroinicial % 2 == 0)
                    Console.WriteLine(numeroinicial);

                numeroinicial--;
            }
        }

        private static void ExemploSwitch()
        {
            bool saiu = false;

            while (!saiu)
            {
                Console.Clear();

                string menu =
    @"Escolha uma opção abaixo:
01 - Imprime a data atual.
02 - Soma dois números.
03 - Sair.
";
                Console.WriteLine(menu);
                string numeroDigitado = Console.ReadLine();

                if (!int.TryParse(numeroDigitado, out var numero))
                {
                    Console.WriteLine(_mensagemInvalido);
                    return;
                }
                Console.Clear(); //limpa o console
                switch (numero)
                {

                    case 1:
                        Console.WriteLine($"{DateTime.Now: dd/MM/yyyy}");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine($"1 + 1 = {1 + 1}");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Tchau & Obrigado");
                        saiu = true;
                        break;

                    default:
                        Console.WriteLine(_mensagemInvalido);
                        Console.ReadKey();
                        break;

                        
                }
               
            }
        }

    }
}


