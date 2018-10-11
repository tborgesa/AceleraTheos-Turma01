/*
 Exercício 02 - Faça segundo projeto (Console Aplication) com as seguintes atribuições: 
 1. Receba um número inteiro do usuário em uma variável "numero".
 2. Faça uma cópia dessa variável para a variável "numeroCopiado". (Passando a váriavel "numero" por referência)
 3. Calcule o dobro da variável "numeroCopiado" e guarde nele mesmo (Lembre-se que qualquer operação entre inteiros precisa ser guardada em uma varíavel)
 4. Imprima as duas varíaveis na tela. 
*/

using System;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int numero = int.Parse(Console.ReadLine());

            ref int numeroCopiado = ref numero;

            numeroCopiado = numeroCopiado * 2;


            Console.WriteLine($"Numero digitado: {numero}");
            Console.WriteLine($"Numero Copiado: {numeroCopiado}");

            Console.ReadKey();
        }
    }
}
