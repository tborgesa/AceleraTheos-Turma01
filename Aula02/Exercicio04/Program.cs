using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valor x Referencia
            // Exercício 02 - Faça segundo projeto (Console Aplication) com as seguintes atribuições: 
            //1.Receba um número inteiro do usuário em uma variável "numero".
            //2.Faça uma cópia dessa variável para a variável "numeroCopiado". (Passando a váriavel "numero" por referência)
            //3.Calcule o dobro da variável "numeroCopiado" e guarde nele mesmo(Lembre-se que qualquer operação entre inteiros precisa ser guardada em uma varíavel)
            //4.Imprima as duas varíaveis na tela.

            int numero;

            Console.WriteLine("Digite Digite um numero por favor");
            numero = Convert.ToInt32(Console.ReadLine());

            ref int numeroCopiado = ref numero;

            numeroCopiado = 2 * numeroCopiado;

            Console.WriteLine($"Numero = {numero}");
            Console.WriteLine($"Numero copiado = {numeroCopiado}");

            Console.ReadKey();

        }
    }
}
