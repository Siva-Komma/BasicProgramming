using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class PrimeFactors
    {
        public static void PrimeFact()
        {
            int num = 0, div = 2;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 1)
            {
                if (num % div == 0)
                {
                    Console.WriteLine("Prime factors: {0}", div);
                    num = num / div;
                }
                else
                {
                    div++;
                }
            }
        }
    }
}
