using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class HarmonicNumber
    {
        public static void HarmonicNum()
        {
            double num = 0, sum = 0, i = 0;
            Console.WriteLine("Enter Number");
            num = Convert.ToDouble(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("1/" + i);
                sum = sum + 1 / i;
            }
            Console.WriteLine("Sum of harmonicnumber: " + sum);
        }
    }
}
