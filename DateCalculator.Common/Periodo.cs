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

        public Periodo(int years, int months, int days)
        {
            this.Seconds = 0;
            this.Minutes = 0;
            this.Hours = 0;
            this.Days = days;
            this.Months = months;
            this.Years = years;
        }

        public Periodo()
        {
            this.Seconds = 0;
            this.Minutes = 0;
            this.Hours = 0;
            this.Days = 0;
            this.Months = 0;
            this.Years = 0;
        }

        public void AddSeconds(int seconds)
        {
            this.Seconds += seconds;

            if (this.Seconds > 59)
            {
                this.Seconds = this.Seconds % 60;
                this.AddMinutes(this.Seconds / 60);
            }
        }

        public void AddMinutes(int minutes)
        {
            this.Minutes += minutes;

            if (this.Minutes > 59)
            {
                this.Minutes = this.Minutes % 60;
                this.AddHours(this.Minutes / 60);
            }
        }

        public void AddHours(int hours)
        {
            this.Hours += hours;

            if (this.Hours > 59)
            {
                this.Hours = this.Hours % 60;
                this.AddDays(this.Hours / 60);
            }
        }

        public void AddDays (int days)
        {
            for (int i = days; i>0; i--)
            {
                this.AddDay();
            }
        }

        public void AddMonths (int months)
        {
            for(int i = months; i>0; i--)
            {
                this.AddMonth();
            }
        }

        public void AddYears (int years)
        {
            this.Years += years;
        }
   
        public void AddDay()
        {
            this.Days += 1;

            if (((this.Months == 1) || (this.Months == 3) || (this.Months == 5) || (this.Months == 7) || (this.Months == 8) || (this.Months == 10) || (this.Months == 12)) && (this.Days > 31)) 
            {
                this.Days = 1;

                this.AddMonth();

            } else if (((this.Months == 0) || (this.Months == 4) || (this.Months == 6) || (this.Months == 9) || (this.Months == 11)) && (this.Days > 30))
            {
                this.Days = 1;

                this.AddMonth();

            } else if ((this.Months == 2) && ((this.Years % 4) == 0) && (this.Days > 29))
            {
                this.Days = 1;

                this.AddMonth();

            } else if ((this.Months == 2) && ((this.Years % 4) != 0) && (this.Days > 28))
            {
                this.Days = 1;

                this.AddMonth();
            }
        }

        public void AddMonth()
        {
            this.Months += 1;

            if (this.Months > 11)
            {
                this.Months = 1;
                this.AddYear();
            }
        }

        public void AddYear()
        {
            this.Years += 1;
        }

        public void RemoveYear()
        {
            this.Years -= 1;
        }

        public void RemoveYears(int years)
        {
            this.Years -= years;
        }

        public void RemoveMonth()
        {
            this.Months -= 1;
            if (this.Months == 0)
            {
                this.RemoveYear();
                this.Months = 12;
            }
        }

        public void RemoveMonths(int months)
        {
            for (int i = months; i > 0; i--)
            {
                this.RemoveMonth();
            }
        }

        public void RemoveDay()
        {
            this.Days -= 1;

            if ((this.Days == 0) && (this.Months != 0))
            {
                this.RemoveMonth();

                if ((this.Months == 1) || (this.Months == 3) || (this.Months == 5) || (this.Months == 7) || (this.Months == 8) || (this.Months == 10) || (this.Months == 12))
                {
                    this.Days = 31;

                }
                else if ((this.Months == 4) || (this.Months == 6) || (this.Months == 9) || (this.Months == 11))
                {
                    this.Days = 30;

                }
                else if ((this.Months == 2) && ((this.Years % 4) == 0))
                {
                    this.Days = 29;

                }
                else if ((this.Months == 2) && ((this.Years % 4) != 0))
                {
                    this.Days = 28;

                }
            }
        }
    }
}
