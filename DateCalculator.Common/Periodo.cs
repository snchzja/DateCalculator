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

        public void AddSecondsDate(int seconds)
        {
            this.Seconds += seconds;

            if (this.Seconds > 59)
            {
                this.Seconds = this.Seconds % 60;
                this.AddMinutesDate(this.Seconds / 60);
            }
        }

        public void AddMinutesDate(int minutes)
        {
            this.Minutes += minutes;

            if (this.Minutes > 59)
            {
                this.Minutes = this.Minutes % 60;
                this.AddHoursDate(this.Minutes / 60);
            }
        }

        public void AddHoursDate(int hours)
        {
            this.Hours += hours;

            if (this.Hours > 59)
            {
                this.Hours = this.Hours % 60;
                this.AddDaysDate(this.Hours / 60);
            }
        }

        public void AddDaysDate(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                this.AddDayDate();
            }
        }

        public void AddMonthsDate(int months)
        {
            for (int i = 1; i < months; i++)
            {
                this.AddMonthDate();
            }
        }

        public void AddYearsDate(int years)
        {
            this.Years += years;
        }

        public void AddDayDate()
        {
            this.Days += 1;

            if (((this.Months == 1) || (this.Months == 3) || (this.Months == 5) || (this.Months == 7) || (this.Months == 8) || (this.Months == 10) || (this.Months == 12)) && (this.Days > 31))
            {
                this.Days = 1;

                this.AddMonthDate();

            }
            else if (((this.Months == 0) || (this.Months == 4) || (this.Months == 6) || (this.Months == 9) || (this.Months == 11)) && (this.Days > 30))
            {
                this.Days = 1;

                this.AddMonthDate();

            }
            else if ((this.Months == 2) && ((this.Years % 4) == 0) && (this.Days > 29))
            {
                this.Days = 1;

                this.AddMonthDate();

            }
            else if ((this.Months == 2) && ((this.Years % 4) != 0) && (this.Days > 28))
            {
                this.Days = 1;

                this.AddMonthDate();
            }
        }

        public void AddMonthDate()
        {
            this.Months += 1;

            if (this.Months > 12)
            {
                this.Months = 1;
                this.AddYearDate();
            }
        }

        public void AddYearDate()
        {
            this.Years += 1;
        }

        public void AddDaysPeriodWithExtraDay(int days)
        {
            for (int i = 0; i <= days; i++)
            {
                this.AddDayPeriod();
            }
        }

        public void AddDaysPeriodNoExtraDay(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                this.AddDayPeriod();
            }
        }
        //TODO que es esto??
        public void AddMonthsPeriod(int months)
        {
            for (int i = 1; i <= months; i++)
            {
                //this.AddMonthDate();
                this.AddMonthPeriod();
            }
        }

        public void AddYearsPeriod(int years)
        {
            this.Years += years;
        }

        public void AddDayPeriod()
        {
            this.Days += 1;

            if (((this.Months == 0) || (this.Months == 2) || (this.Months == 4) || (this.Months == 6) || (this.Months == 7) || (this.Months == 9) || (this.Months == 11)) && (this.Days > 30))
            {
                this.Days = 0;

                this.AddMonthPeriod();
                
            }
            else if (((this.Months == 3) || (this.Months == 5) || (this.Months == 8) || (this.Months == 10)) && (this.Days > 29))
            {
                this.Days = 0;

                this.AddMonthPeriod();

            }
            else if ((this.Months == 1) && ((this.Years % 4) == 0) && (this.Days > 28))
            {
                this.Days = 0;

                this.AddMonthPeriod();

            }
            else if ((this.Months == 1) && ((this.Years % 4) != 0) && (this.Days > 27))
            {
                this.Days = 0;

                this.AddMonthPeriod();
            }
        }

        public void AddMonthPeriod()
        {
            this.Months += 1;

            if (this.Months > 11)
            {
                this.Months = 0;
                this.AddYearPeriod();
            }
        }

        public void AddYearPeriod()
        {
            this.Years += 1;
        }

        public void AddGenericDays(int days)
        {
            for (int i = 1; i <= days; i++)
            {
                this.Days += 1;

                if (this.Days >= 30)
                {
                    this.Days = 0;
                    this.AddMonthDate();
                }
            }
        }

        public void RemoveYearDate()
        {
            this.Years -= 1;
        }

        public void RemoveYearsDate(int years)
        {
            this.Years -= years;
        }

        public void RemoveMonthDate()
        {
            this.Months -= 1;
            if (this.Months == 0)
            {
                this.RemoveYearDate();
                this.Months = 12;
            }
        }

        public int RemoveMonthDateWithAnswer()
        {
            if (this.Months == 1)
            {
                this.Months = 12;
                this.RemoveYearDate();
                return 31;
            }
            else if (this.Months == 2)
            {
                this.Months = 1;
                return 31;
            }
            else if (this.Months == 3)
            {
                if (this.Years % 4 == 0)
                {
                    this.Months = 2;
                    return 29;
                }
                else
                {
                    this.Months = 2;
                    return 28;
                }
            }
            else if (this.Months == 4)
            {
                this.Months = 3;
                return 31;
            }
            else if (this.Months == 5)
            {
                this.Months = 4;
                return 30;
            }
            else if (this.Months == 6)
            {
                this.Months = 5;
                return 31;
            }
            else if (this.Months == 7)
            {
                this.Months = 6;
                return 30;
            }
            else if (this.Months == 8)
            {
                this.Months = 7;
                return 31;
            }
            else if (this.Months == 9)
            {
                this.Months = 8;
                return 31;
            }
            else if (this.Months == 10)
            {
                this.Months = 9;
                return 30;
            }
            else if (this.Months == 11)
            {
                this.Months = 10;
                return 31;
            }
            else if (this.Months == 12)
            {
                this.Months = 11;
                return 30;
            }

            return 0;
        }

        public int RemoveMonthPeriodWithAnswer()
        {
            if (this.Months == 0)
            {
                this.Months = 11;
                this.RemoveYearDate();
                return 31;
            }
            else if (this.Months == 1)
            {
                this.Months = 0;
                return 31;
            }
            else if (this.Months == 2)
            {
                if (this.Years % 4 == 0)
                {
                    this.Months = 1;
                    return 29;
                }
                else
                {
                    this.Months = 1;
                    return 28;
                }
            }
            else if (this.Months == 3)
            {
                this.Months = 2;
                return 31;
            }
            else if (this.Months == 4)
            {
                this.Months = 3;
                return 30;
            }
            else if (this.Months == 5)
            {
                this.Months = 4;
                return 31;
            }
            else if (this.Months == 6)
            {
                this.Months = 5;
                return 30;
            }
            else if (this.Months == 7)
            {
                this.Months = 6;
                return 31;
            }
            else if (this.Months == 8)
            {
                this.Months = 7;
                return 31;
            }
            else if (this.Months == 9)
            {
                this.Months = 8;
                return 30;
            }
            else if (this.Months == 10)
            {
                this.Months = 9;
                return 31;
            }
            else if (this.Months == 11)
            {
                this.Months = 10;
                return 30;
            }

            return 0;
        }

        public void RemoveMonthsDate(int months)
        {
            for (int i = 1; i <= months; i++)
            {
                this.RemoveMonthDate();
            }
        }

        public void RemoveDayDate()
        {
            this.Days -= 1;

            if ((this.Days == 0) && (this.Months != 0))
            {
                this.RemoveMonthDate();

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
