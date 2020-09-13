using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.Common
{
    public static class DateTimeCalculator
    {
        public static long ToSeconds(DateTime fecha)
        {
            // Inicializacion

            long _result;
            long _years = fecha.Year;
            long _months = fecha.Month;
            long _days = fecha.Day;
            long _hours = fecha.Hour;
            long _minutes = fecha.Minute;
            long _seconds = fecha.Second;

            // Tratamos segundos, minutos, horas y dias

            _result = (_seconds-1) + (_minutes-1) * 60 + (_hours-1) * 3600 + (_days-1) * 86400;

            // Tratamos meses

            while (_months > 1)
            {
                _months -= 1;

                if ((_months == 1) || (_months == 3) || (_months == 5) || (_months == 7) || (_months == 8) || (_months == 10))
                {
                    _result += 31 * 86400;
                }
                else
                {
                    if ((_months == 4) || (_months == 6) || (_months == 9) || (_months == 11))
                    {
                        _result += 30 * 86400;
                    }
                    else
                    {
                        if (_months == 2)
                        {
                            if (_years % 4 == 0)
                            {
                                _result += 29 * 86400;
                            }
                            else
                            {
                                _result += 28 * 86400;
                            }
                        }
                        
                    }
                }
            }

            // Tratamos años

            while (_years > 1)
            {
                _years -= 1;

                if (_years % 4 == 0)
                {
                    _result += 366 * 86400;
                }
                else
                {
                    _result += 365 * 86400;
                }

            }

            // Devolvemos el resultado

            return _result;
        }

        public static Periodo SecondsToDateTime(long seconds)
        {
            long _years = 0;
            long _months = 0;
            long _days;
            long _hours;
            long _minutes;

            // Tratamos los años
            while (((seconds >= 31536000) && (_years % 4 != 0)) || ((seconds >= 31622400) && (_years % 4 == 0)))
            {

                if (_years % 4 == 0)
                {
                    seconds -= 31622400;
                }
                else
                {
                    seconds -= 31536000;
                }

                _years += 1;
            }

            // Tratamos los meses

            while (
                     (
                       ((_months + 1 == 1) || (_months + 1 == 3) || (_months + 1 == 5) || (_months + 1 == 7) || (_months + 1 == 8) || (_months + 1 == 10) || (_months + 1 == 12))
                       &&
                       (seconds >= 2678400)
                     )
                     ||
                     (
                       ((_months + 1 == 4) || (_months + 1 == 6) || (_months + 1 == 9) || (_months + 1 == 11))
                       &&
                       (seconds >= 2592000)
                     )
                     ||
                     ((_months + 1 == 2) && (_years % 4 == 0) && (seconds >= 2505600))
                     ||
                     ((_months + 1 == 2) && (_years % 4 != 0) && (seconds >= 2419200))
                   )
            {
                _months += 1;

                if ((_months == 1) || (_months == 3) || (_months == 5) || (_months == 7) || (_months == 8) || (_months == 10) || (_months == 12))
                {
                    seconds -= 2678400;
                }
                else
                {
                    if ((_months == 4) || (_months == 6) || (_months == 9) || (_months == 11))
                    {
                        seconds -= 2592000;
                    }
                    else
                    {
                        if (_years % 4 == 0)
                        {
                            seconds -= 2505600;
                        }
                        else
                        {
                            seconds -= 2419200;
                        }
                    }
                }
            }

            // Tratamos dias
            _days = seconds / 86400;
            seconds %= 86400;

            //Horas
            _hours = seconds / 3600;
            seconds %= 3600;

            //Minutos
            _minutes = seconds / 60;
            seconds %= 60;

            return new Periodo(Convert.ToInt32(_years), Convert.ToInt32(_months), Convert.ToInt32(_days), Convert.ToInt32(_hours), Convert.ToInt32(_minutes), Convert.ToInt32(seconds));
        }

    }
}
