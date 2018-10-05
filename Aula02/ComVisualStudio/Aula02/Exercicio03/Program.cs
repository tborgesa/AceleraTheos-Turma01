using System;

/* Exercício 01 - Faça um projeto (Console Aplication) com as seguintes atribuições: 
 1. Receba um número inteiro do usuário em uma variável "numero".
 2. Faça uma cópia dessa variável para a variável "numeroCopiado". (Passando a váriavel "numero" por valor)
 3. Calcule o dobro da variável "numeroCopiado" e guarde nele mesmo (Lembre-se que qualquer operação entre inteiros precisa ser guardada em uma varíavel)
 4. Imprima as duas varíaveis na tela.
 */

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número. ");
            int numero = Convert.ToInt32(Console.ReadLine()); //converter a captura de string para int

            int numerocopiado = numero *2 ;

            Console.WriteLine($"O valor da variável número é: {numero}.");
            Console.WriteLine($"O valor da variável númerocopiado é: {numerocopiado}.");

        }
    }
}
