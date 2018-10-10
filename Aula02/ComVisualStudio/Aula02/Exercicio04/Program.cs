using System;
/*Exercício 02 - Faça segundo projeto (Console Aplication) com as seguintes atribuições: 
 1. Receba um número inteiro do usuário em uma variável "numero".
 2. Faça uma cópia dessa variável para a variável "numeroCopiado". (Passando a váriavel "numero" por referência)
 3. Calcule o dobro da variável "numeroCopiado" e guarde nele mesmo (Lembre-se que qualquer operação entre inteiros precisa ser guardada em uma varíavel)
 4. Imprima as duas varíaveis na tela.*/

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um númemro");
            int numero = Convert.ToInt32(Console.ReadLine());

            ref int numerocopiado = ref numero;
            numerocopiado = numerocopiado * 2;

            Console.WriteLine($"O valor da variável numero é: {numero}");
            Console.WriteLine($"O valor da variável numerocopiado é: {numerocopiado}");
        }
    }
}
