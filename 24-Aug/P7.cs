using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class P7
    {
        public static void dateproperty()
        {
            System.DateTime moment = new System.DateTime(2022, 08, 25, 3, 57, 32, 11);

            Console.WriteLine("year = " + moment.Year);

            Console.WriteLine("month = " + moment.Month);

            Console.WriteLine("day = " + moment.Day);

            Console.WriteLine("hour = " + moment.Hour);

            Console.WriteLine("minute = " + moment.Minute);

            Console.WriteLine("second = " + moment.Second);

            Console.WriteLine("millisecond = " + moment.Millisecond);
            Console.ReadLine();

        }
    }
}
