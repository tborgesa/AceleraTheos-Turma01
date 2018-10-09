using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Conversão de tipos integrais");

            short tipoShort = 256;
            byte tipoByte = (byte)tipoShort;

            Console.WriteLine($"tipo short é {tipoShort} e em byte ficou {tipoByte}.");
            Console.ReadKey();*/


            Console.WriteLine("Conversão de tipos flutuantes");
            double tipoDouble = 80.76;
            int tipoInt = (int)tipoDouble;

            Console.WriteLine($"Tipo double é {tipoDouble} e em int ficou {tipoInt}");
            Console.ReadKey();

        }
    }
}
