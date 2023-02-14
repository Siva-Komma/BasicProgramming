using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class EvenorOdd
    {
        public static void CheckNumberEvenorOdd()
        {
            int num = 0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even number: " + num);
            }
            else
            {
                Console.WriteLine("Odd Number: " + num);
            }
        }
    }
}
