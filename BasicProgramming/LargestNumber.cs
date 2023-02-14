using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class LargestNumber
    {
        public static void FindLargestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("Find the largest of three number");
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The Firstnumber is greater among three");
                }
                else
                {
                    Console.WriteLine("The third number is greater among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The Second number is greater among three");
            }
            else
            {
                Console.WriteLine("The Third Number is greater among three");
            }
        }
    }
}
