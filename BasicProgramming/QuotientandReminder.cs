using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class QuotientandReminder
    {
        public static void FindQuotientAndReminder()
        {
            int dividend = 20, divisor = 10;
            int quotient = dividend / divisor;
            int reminder = dividend % divisor;
            Console.WriteLine("Dividend: {0} Divisor: {1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + reminder);
        }
    }
}
