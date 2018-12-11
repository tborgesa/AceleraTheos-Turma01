namespace ProvaInicial.ReajusteSalarial
{
    public class Salario
    {
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
    }
}
