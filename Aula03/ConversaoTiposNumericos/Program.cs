using System;

namespace ConversaoTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            //convertendo um short para byte (8 bit)
            Console.WriteLine("Conversão de tipos integrais");
            short tipoShort = 256; //0100000000
            byte tipoByte = (byte)tipoShort; //00000000

            Console.WriteLine($"tipoShort: {tipoShort}");
            Console.WriteLine($"tipoByte: {tipoByte}");

            Console.WriteLine();
            //convertendo double pra int
            Console.WriteLine("Conversão de tipos flutuantes");
            double tipoDouble = 80.76;
            int tipoInt = (int)tipoDouble;

            Console.WriteLine($"tipoDouble: {tipoDouble}");
            Console.WriteLine($"tipoInt: {tipoInt}");


            Console.ReadKey();
        }
    }
}
