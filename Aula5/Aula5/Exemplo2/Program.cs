using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. O fechamento contábil anual sempre acontece no ultimo dia do ano.
            //Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.

            Console.WriteLine("Por favor, informe o ano do fechamento contábil.");
            int anoFechamento = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a data de fechamento é 31/12/{anoFechamento}.");

            Console.ReadKey();
        }
    }
}
