using System;

namespace ProvaInicial.AlteracaoSenhaDia
{
    public class SenhaDia
    {
        public int CalcularSenhaDia(DateTime data)
        {
            int valorBase = data.Year + data.Month * data.Day;
            return valorBase / ((data.Day % 5) + 1);
        }
    }
}
