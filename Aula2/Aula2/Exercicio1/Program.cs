using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("por favor, informe um número: ");

            int numero = Convert.ToInt32(Console.ReadLine());
            int numeroCopiado = numero;
            numeroCopiado = numeroCopiado * 2;

            Console.WriteLine($"O numero é: {numero}, e o dobro do numero é:  {numeroCopiado} ");
            Console.ReadKey();
        }
    }
}

            /*Qd vc passa a variável por valor para um método ou função, o método que recebe essa variável recebe, 
             * na verdade, uma cópia dessa variável...Ou seja, se vc modificar a variável dentro desse método ou função, 
             * vc está modificando a cópia da variável...Qd a execução do método ou função terminar, 
             * a variável q foi passada por valor continuará igualzinha como ela estava antes do método ou função ter sido chamado...

            Já passando a variável por referência, vc está passando tipo um "ponteiro" para o
            endereço de memória que está aquela variável...Ou seja, se vc modificar a variável dentro do método ou função, 
            a variável em si será alterada... 
            O que faz com que, acabando a execução do método, se vc tiver alterado o valor da variável, 
            o valor fora dessa função ou método será também alterado...*/