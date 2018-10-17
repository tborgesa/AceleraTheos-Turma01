using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 2. O fechamento contábil anual sempre acontece no ultimo dia do ano.
	Solicite ao usuário o ano de fechamento e retorne a data que será feito o fechamento Contábil.
     */

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = "2018";
            DateTime aux = DateTime.Parse("31/12/"+user);

            Console.WriteLine($"{aux:dd/MM/yyyy}");


            Console.ReadKey();
        }
    }
}
