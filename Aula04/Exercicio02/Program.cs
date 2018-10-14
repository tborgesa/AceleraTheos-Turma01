using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Peça para o usuário digitar o endereço completo (Rua, Bairro e Cidade) separados por ',' e apresente para ele cada item separado.
            Console.WriteLine("Digite Rua, Bairro e Cidade separando por virgula");

            string endereco ;

            endereco = Console.ReadLine();

            string rua = endereco.Substring(0,endereco.IndexOf(","));
            string restoEndereco = endereco.Substring(endereco.IndexOf(','));
            string bairro = restoEndereco.Substring(restoEndereco.IndexOf(','),restoEndereco.LastIndexOf(','));           
            string cidade = endereco.Substring(endereco.LastIndexOf(',')+1);
           
            




            Console.WriteLine("resto"+restoEndereco);
            Console.WriteLine($"sua rua é {rua.TrimStart()}");
            Console.WriteLine($"seu bairro é {bairro.TrimStart(',', ' ')}");
            Console.WriteLine($"sua cidade é {cidade.TrimStart()}");

                                 

            Console.ReadKey();
        }
    }
}
