using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Solicite ao usuário 10 números e no final diga quantos números são menores que 100, 
            //quantos estão entre 100 e 200 e quantos são maiores que 200.

            var _mensagemErrado = "erro";
            int men100=0, entre=0, mai100=0;


            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Digite um numero");
                string stringNumero = Console.ReadLine();
                if (!int.TryParse(stringNumero, out int numero))
                {
                    Console.WriteLine(_mensagemErrado);
                    continue;
                }
                else
                {
                    if (numero < 100)
                        men100++;
                    else if (numero > 100 && numero < 200)
                        entre++;
                    else
                        mai100++;
                }
            }
            Console.WriteLine($"Menores que 100 : {men100}, entre 100 e 200 : {entre} e maiores que 200 : {mai100}");
            Console.ReadKey();

        }   
    }
}
