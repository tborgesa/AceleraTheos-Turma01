using System;

namespace ConversaoTiposNumericos_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de tipos integrais");

            short tipoShort = 256;
            byte tipoByte = (byte)tipoShort;

            Console.WriteLine($"Tipo Short: {tipoShort}");
            Console.WriteLine($"Tipo Byte: {tipoByte}");

            Console.WriteLine("Conversão de tipos flutuantes");
            double tipoDouble = 10.96;
          //  int tipoInt = (double)tipoDouble;


           
            Console.ReadKey();

        }
    }
}
