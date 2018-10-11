using System;

namespace ConversaoTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de tipos integrais");
            short tipoShort = 256;
            byte tipoByte = (byte)tipoShort;
            Console.WriteLine($"tipoShort: {tipoShort}");
            Console.WriteLine($"tipoByte: {tipoByte}");


            Console.WriteLine("Conversão de tipos flutuantes");
            double tipoDouble = 80.76;
            int tipoInt = (int)tipoDouble;
            Console.WriteLine($"tipoDouble: {tipoDouble}");
            Console.WriteLine($"tipoInt: {tipoInt}");

            Console.ReadKey();
        }
    }
}
