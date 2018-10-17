using System;

namespace ProvaInicial.ReajusteSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Questão 2 (2 pontos)

                Os diretores da empresa “Solução Mentor” decidirem dar uma aumento para toda a equipe de desenvolvimento
                e fizeram o reajuste de acordo com o código abaixo:

                public double ReajusteSalario(double salario)
                {
                    if (salario < 1200.05) 
                        return salario * 1.2;
    
                    else if (salario < 2540.56)
                        return salario + salario * 0.15;

                    else if (salario < 3852)
                        return salario * (110 / 100);

                    else if (salario < 4150)
                        return salario + salario * 0.05;

                    return salario++;
                }

                Calcule o novo salário dos seguintes funcionários:

                José (Salário Atual: R$ 900,00) (0,5 ponto)
                Maria (Salário Atual: R$ 2.200,00) (0,5 ponto)
                João (Salário Atual: R$ 3.852,00) (0,5 ponto)
                Joaquina (Salário Atual: R$ 4.500,00) (0,5 ponto)
            */


            var salarioJose = 900;
            var salarioMaria = 2200;
            var salarioJoão = 3852;
            var salarioJoaquina = 4500;

            Console.WriteLine(new Salario().ReajusteSalario(salarioJose)); // 1080
            Console.WriteLine(new Salario().ReajusteSalario(salarioMaria)); // 2530
            Console.WriteLine(new Salario().ReajusteSalario(salarioJoão)); //4044,6
            Console.WriteLine(new Salario().ReajusteSalario(salarioJoaquina)); //4500
            Console.ReadKey();

        }
    }
}
