using DateCalculator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateCalculator.ConsoleFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inicio1 = new DateTime(2008, 10, 29, 0, 0, 0);
            DateTime fin1 = new DateTime(2008, 10, 31, 0, 0, 0);

            DateTime inicio2 = new DateTime(2009, 03, 02, 0, 0, 0);
            DateTime fin2 = new DateTime(2010, 03, 03, 0, 0, 0);

            DateTime inicio3 = new DateTime(2010, 04, 19, 0, 0, 0);
            DateTime fin3 = new DateTime(2010, 04, 23, 0, 0, 0);

            DateTime inicio4 = new DateTime(2010, 05, 01, 0, 0, 0);
            DateTime fin4 = new DateTime(2018, 04, 02, 0, 0, 0);

            DateTime inicio5 = new DateTime(2018, 04, 03, 0, 0, 0);
            DateTime fin5 = new DateTime(2018, 09, 26, 0, 0, 0);

            DateTime inicioF = new DateTime(2010, 5, 1, 0, 0, 0);
            DateTime finF = new DateTime(2018, 4, 2, 0, 0, 0);

            Periodo resultado1 = PeriodCalculator.CalcularPeriodo(inicio1, fin1);
            Periodo resultado2 = PeriodCalculator.CalcularPeriodo(inicio2, fin2);
            Periodo resultado3 = PeriodCalculator.CalcularPeriodo(inicio3, fin3);
            Periodo resultado4 = PeriodCalculator.CalcularPeriodo(inicio4, fin4);
            Periodo resultado5 = PeriodCalculator.CalcularPeriodo(inicio5, fin5);
            Periodo resultadoF = PeriodCalculator.CalcularPeriodo(inicioF, finF);

            //resultado1.AddDayDate();
            //resultado2.AddDayDate();
            //resultado3.AddDayDate();
            //resultado4.AddDayDate();
            //resultadoF.AddDayDate();

            //long inicioEnSegundos1 = DateTimeCalculator.ToSeconds(inicio1);
            //long finEnSegundos1 = DateTimeCalculator.ToSeconds(fin1);

            //long inicioEnSegundos2 = DateTimeCalculator.ToSeconds(inicio2);
            //long finEnSegundos2 = DateTimeCalculator.ToSeconds(fin2);

            //long inicioEnSegundos3 = DateTimeCalculator.ToSeconds(inicio3);
            //long finEnSegundos3 = DateTimeCalculator.ToSeconds(fin3);

            //long inicioEnSegundos4 = DateTimeCalculator.ToSeconds(inicio4);
            //long finEnSegundos4 = DateTimeCalculator.ToSeconds(fin4);

            //long inicioEnSegundos5 = DateTimeCalculator.ToSeconds(inicio5);
            //long finEnSegundos5 = DateTimeCalculator.ToSeconds(fin5);

            //long inicioEnSegundosF = DateTimeCalculator.ToSeconds(inicioF);
            //long finEnSegundosF = DateTimeCalculator.ToSeconds(finF);

            //Periodo resultado1 = DateTimeCalculator.SecondsToDateTime(finEnSegundos1 + 86400 - inicioEnSegundos1);
            //Periodo resultado2 = DateTimeCalculator.SecondsToDateTime(finEnSegundos2 + 86400 - inicioEnSegundos2);
            //Periodo resultado3 = DateTimeCalculator.SecondsToDateTime(finEnSegundos3 + 86400 - inicioEnSegundos3);
            //Periodo resultado4 = DateTimeCalculator.SecondsToDateTime(finEnSegundos4 + 86400 - inicioEnSegundos4);
            //Periodo resultado5 = DateTimeCalculator.SecondsToDateTime(finEnSegundos5 + 86400 - inicioEnSegundos5);

            //Periodo resultadoF = DateTimeCalculator.SecondsToDateTime(finEnSegundosF + 86400 - inicioEnSegundosF);

            //long total = (finEnSegundos1 + 86400 - inicioEnSegundos1) + (finEnSegundos2 + 86400 - inicioEnSegundos2) + (finEnSegundos3 + 86400 - inicioEnSegundos3) + (finEnSegundos4 + 86400 - inicioEnSegundos4);
            //Periodo totalGeneral = DateTimeCalculator.SecondsToDateTime(total);

            //TimeSpan interval1 = fin1 - inicio1;
            //TimeSpan interval2 = fin2 - inicio2;
            //TimeSpan interval3 = fin3 - inicio3;
            //TimeSpan interval4 = fin4 - inicio4;
            //TimeSpan interval5 = fin5 - inicio5;

            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio1, fin1, resultado1.Years, resultado1.Months, resultado1.Days, resultado1.Hours, resultado1.Minutes, resultado1.Seconds);
            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio2, fin2, resultado2.Years, resultado2.Months, resultado2.Days, resultado2.Hours, resultado2.Minutes, resultado2.Seconds);
            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio3, fin3, resultado3.Years, resultado3.Months, resultado3.Days, resultado3.Hours, resultado3.Minutes, resultado3.Seconds);
            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio4, fin4, resultado4.Years, resultado4.Months, resultado4.Days, resultado4.Hours, resultado4.Minutes, resultado4.Seconds);
            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio5, fin5, resultado5.Years, resultado5.Months, resultado5.Days, resultado5.Hours, resultado5.Minutes, resultado5.Seconds);
            //Console.WriteLine("Total General = {0}-{1}-{2} {3}:{4}:{5}", totalGeneral.Years, totalGeneral.Months, totalGeneral.Days, totalGeneral.Hours, totalGeneral.Minutes, totalGeneral.Seconds);
            //Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("{0} - {1} = {2}", fin1, inicio1, interval1.ToString());
            //Console.WriteLine("{0} - {1} = {2}", fin2, inicio2, interval2.ToString());
            //Console.WriteLine("{0} - {1} = {2}", fin3, inicio3, interval3.ToString());
            //Console.WriteLine("{0} - {1} = {2}", fin4, inicio4, interval4.ToString());
            //Console.WriteLine("{0} - {1} = {2}", fin5, inicio5, interval5.ToString());
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicioF, finF, resultadoF.Years, resultadoF.Months, resultadoF.Days, resultadoF.Hours, resultadoF.Minutes, resultadoF.Seconds);
            Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("{0} {1} {2}", inicioEnSegundosF, finEnSegundosF, finEnSegundosF - inicioEnSegundosF);
            //Console.WriteLine("{0} {1} {2}", inicioEnSegundos2, finEnSegundos2, finEnSegundos2 - inicioEnSegundos2);
            //Console.WriteLine("-----------------------------------------------------------------");
            //long a = 0;
            //long b = 4;
            //Console.WriteLine("{0} - {1}", a / b, a % b);

            //TimeSpan date1 = (fin1 - inicio1);
            //TimeSpan date2 = (fin2 - inicio2);
            //TimeSpan date3 = (fin3 - inicio3);
            //TimeSpan date4 = (fin4 - inicio4);

            //TimeSpan undia = new System.TimeSpan(1, 0, 0, 0);
            //date1 += undia;
            //date1 += undia;
            //date2 += undia;
            //date3 += undia;
            //date4 += undia;

            //Periodo puaj1 = new Periodo();
            //Periodo puaj2 = new Periodo();
            //Periodo puaj3 = new Periodo();
            //Periodo puaj4 = new Periodo();

            //puaj1.AddGenericDays(date1.Days);
            //puaj2.AddGenericDays(date2.Days);
            //puaj3.AddGenericDays(date3.Days);
            //puaj4.AddGenericDays(date4.Days);

            //puaj1.AddDaysPeriod(date1.Days);
            //puaj2.AddDaysPeriod(date2.Days);
            //puaj3.AddDaysPeriod(date3.Days);
            //puaj4.AddDaysPeriod(date4.Days);


            //Console.WriteLine($"fin - inicio = {date1.Days}");
            //Console.WriteLine($"fin - inicio = {date2.Days}");
            //Console.WriteLine($"fin - inicio = {date3.Days}");
            //Console.WriteLine($"fin - inicio = {date4.Days}");
            Console.WriteLine("-----------------------------------------------------------------");
            //Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio1, fin1, puaj1.Years, puaj1.Months, puaj1.Days, puaj1.Hours, puaj1.Minutes, puaj1.Seconds);
            //Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio2, fin2, puaj2.Years, puaj2.Months, puaj2.Days, puaj2.Hours, puaj2.Minutes, puaj2.Seconds);
            //Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio3, fin3, puaj3.Years, puaj3.Months, puaj3.Days, puaj3.Hours, puaj3.Minutes, puaj3.Seconds);
            //Console.WriteLine("DESDE {0} HASTA {1} = {2}-{3}-{4} {5}:{6}:{7}", inicio4, fin4, puaj4.Years, puaj4.Months, puaj4.Days, puaj4.Hours, puaj4.Minutes, puaj4.Seconds);
            Console.WriteLine("-----------------------------------------------------------------");
            Console.ReadLine();



        }
    }
}
