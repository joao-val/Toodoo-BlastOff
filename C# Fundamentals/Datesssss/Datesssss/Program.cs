using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datesssss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);
            Console.WriteLine("--------------");
            var timeSpanNanoseconds = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoseconds);
            Console.WriteLine("--------------");

            var timeSpanHourMinuteSecond = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHourMinuteSecond);
            Console.WriteLine("--------------");

            var timeSpanDayHourMinuteSecond = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDayHourMinuteSecond);
            Console.WriteLine("--------------");

            var timeSpanDayHourMinuteSecondMillisecond = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDayHourMinuteSecondMillisecond);
            Console.WriteLine("--------------");

            Console.WriteLine(timeSpanHourMinuteSecond - timeSpanDayHourMinuteSecond);
            Console.WriteLine("--------------");

            Console.WriteLine(timeSpanDayHourMinuteSecond.Days);
            Console.WriteLine("--------------");

            Console.WriteLine(timeSpanDayHourMinuteSecond.Add(new TimeSpan(12, 0, 0)));
            Console.WriteLine("--------------");

            //Métodos
            Console.WriteLine(DateTime.DaysInMonth(2022, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(IsWeekday(DateTime.Now.DayOfWeek));
            Console.WriteLine("--------------");

            //É horário de verão?
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        }

        //É Final de semana?
        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

        //É meio de semana?
        static bool IsWeekday(DayOfWeek today)
        {
            return today != DayOfWeek.Saturday || today != DayOfWeek.Sunday;
        }
    }
}
