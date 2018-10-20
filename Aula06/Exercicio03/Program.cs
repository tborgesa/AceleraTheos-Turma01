using System;

/*3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100,quantos estão entre 100 e 200 e quantos são maiores que 200.*/
namespace Exercicio03
{
    class Program
    {
        static string _mensagemInvalido = "Entrada inválida, execute o sistema e tente novamente!";
        static int entrada, cont100, cont100e200, maior200;

        static void Main(string[] args)
        {
            int aux = 1;

            while (aux <= 10)
            {
                Console.Clear();

                Console.WriteLine("Insira um valor inteiro");
                var put = Console.ReadLine();


                if (!int.TryParse(put, out entrada))
                {
                    Console.WriteLine(_mensagemInvalido);
                    Console.ReadKey();
                    continue;
                }

                else if (entrada <= 100)
                {
                    cont100++;
                }

                else if (entrada > 100 || entrada <= 200)
                {
                    cont100e200++;
                }

                else if (entrada > 200)
                {
                    maior200++;
                }

                aux++;

            }

            Console.Clear();

            Console.WriteLine($"Quantidade menor que 100: {cont100}");
            Console.WriteLine($"Quantidade amior que 100 e menor que 200: {cont100e200}");
            Console.WriteLine($"Quantidade maior que 200: {maior200}");

            Console.ReadKey();

        }
    }
}
