using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Common
{
    public class Periodo
    {
        public int Seconds { get; set; }
        public int Minutes { get; set; }
        public int Hours { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public int Years { get; set; }

        public Periodo(int years, int months, int days, int hours, int minutes, int seconds)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours;
            this.Days = days;
            this.Months = months;
            this.Years = years;
        }
    }
}
