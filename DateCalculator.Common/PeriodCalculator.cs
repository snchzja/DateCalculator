using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Common
{
    public static class PeriodCalculator
    {
        public static Periodo CalcularPeriodo(DateTime inicio, DateTime fin)
        {
            Periodo result = new Periodo();
            Periodo aux = new Periodo(inicio.Year, inicio.Month, inicio.Day);

            while ((fin.Day != aux.Days) || (fin.Month != aux.Months) || (fin.Year != aux.Years))
            {
                aux.AddDay();
                result.AddDay();
            }

            return result;
        }
    }
}
