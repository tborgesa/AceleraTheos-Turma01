using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.A contabilização de uma determinada "Conta a Pagar" é feita sempre no primeiro dia do mês da data de emissão.
            //Solicite a data de emissão da conta a Pagar e retorne o primeiro dia do mês da emissão.

            Console.WriteLine("Digite a data da emissão");

            DateTime dataEmissao = new DateTime();
            dataEmissao = DateTime.Parse(Console.ReadLine()) ;
            Console.Clear();

            DateTime dataPrimeiroDia = new DateTime(dataEmissao.Year,dataEmissao.Month,01);

            Console.WriteLine($"O primeiro dia do mês emissão é : {dataPrimeiroDia:dd/MM/yyyy}");

            Console.ReadKey();


        }
    }
}
