using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class PowerofTwo
    {
        public static void Power()
        {
            int num = 0, i = 0;
            double power = 0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                power = Math.Pow(2, i);
                Console.WriteLine("2^{0}={1}: ", i, power);
            }
        }
    }
}
