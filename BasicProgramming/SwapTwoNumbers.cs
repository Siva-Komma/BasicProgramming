using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class SwapTwoNumbers
    {
        public static void Swapping()
        {
            int firstnum = 20, secondnum = 30;
            Console.WriteLine("First and second values: " + firstnum + ", " + secondnum);
            firstnum = firstnum * secondnum;
            secondnum = firstnum / secondnum;
            firstnum = firstnum / secondnum;
            Console.WriteLine("First and second values: " + firstnum + ", " + secondnum);
        }
    }
}
