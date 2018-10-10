using System;

namespace ConversaoTipoNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Tipos Numericos");

            short tipoShort = 256;
            byte tipoByte = (byte)tipoShort;

            Console.WriteLine($"tipoShort: {tipoShort}");
            Console.WriteLine($"tipoByte: {tipoByte}");


            Console.WriteLine("Conversão de Tipos flutuantes");

            double tipoDouble = 50.86;
            int tipoInt = (int)tipoDouble;

            Console.WriteLine($"tipoDouble: {tipoDouble}.");
            Console.WriteLine($"tipoInt: {tipoInt}");

            Console.ReadKey();
        }
    }
}
