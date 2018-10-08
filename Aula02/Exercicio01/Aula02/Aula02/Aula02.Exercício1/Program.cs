using System;

/*
 Exercício 01 - Faça um projeto (Console Aplication) com as seguintes atribuições: 
 1. Receba um número inteiro do usuário em uma variável "numero".
 2. Faça uma cópia dessa variável para a variável "numeroCopiado". (Passando a váriavel "numero" por valor)
 3. Calcule o dobro da variável "numeroCopiado" e guarde nele mesmo (Lembre-se que qualquer operação entre inteiros precisa ser guardada em uma varíavel)
 4. Imprima as duas varíaveis na tela.
*/
namespace Aula02.Exercício1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = Convert.ToInt32(Console.ReadLine());
            int numeroCopiado = numero;
            numeroCopiado += numeroCopiado;

            Console.WriteLine($"Valor do número :{numero}, Valor do copiado {numeroCopiado}");
            Console.ReadKey();
        }
    }
}
