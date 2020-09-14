using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Common
{
    public static class PeriodCalculator
    {
        public static Periodo CalcularPeriodo(DateTime inicio, DateTime fin)
        {
            Periodo result = new Periodo();
            
            if (fin.Year >= inicio.Year)
            { 
                result.AddYearsPeriod(fin.Year - inicio.Year);

            } else { return new Periodo(); }

            if (fin.Month >= inicio.Month)
            {
                result.AddMonthsPeriod(fin.Month - inicio.Month);
            }
            else
            {
                if (fin.Year > inicio.Year)
                {
                    result.RemoveYearDate();
                    result.AddMonthsPeriod((fin.Month + 12 - inicio.Month));

                } 
                else
                {
                    return new Periodo();
                }
            }

            if (fin.Day >= inicio.Day)
            {
                result.AddDaysPeriod((fin.Day - inicio.Day));

            } else if ((fin.Year > inicio.Year) || (fin.Month > inicio.Month))
            {
                int dias = result.RemoveMonthDateWithAnswer();
                result.AddDaysPeriod((fin.Day + (dias) - inicio.Day));
            }
            else
            {
                return new Periodo();
            }

            return result;
        }
    }
}
