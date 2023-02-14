using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class LeapYear
    {
        public static void LeapYearP()
        {
            int year = 0;
            Console.WriteLine("Ente Year");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 400 == 0) || (year % 100 != 0) && (year % 4 == 0))
            {
                Console.WriteLine("Year is Leap Year: {0}", year);
            }
            else
            {
                Console.WriteLine("Year is not Leap Year: {0}", year);
            }
        }
    }
}
