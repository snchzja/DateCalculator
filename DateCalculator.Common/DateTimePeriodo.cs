using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Common
{
    public class DateTimePeriodo
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }

        public DateTimePeriodo(DateTime inicio, DateTime fin)
        {
            this.Inicio = inicio;
            this.Fin = fin;
        }
    }
}
