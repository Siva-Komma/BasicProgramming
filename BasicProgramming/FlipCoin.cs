using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class FlipCoin
    {
        public static void Flip()
        {
            Console.WriteLine("Enter number for number of flips");
            //int head = 0, tail = 0,
            int headcount = 0, tailcount = 0;
            double HeadPercentage = 0.0;
            double tailPercentage = 0.0;
            int Coin = Convert.ToInt32(Console.ReadLine());
            if (Coin > 0)
            {
                for (int i = 0; i < Coin; i++)
                {
                    Random r = new Random();
                    int num = r.Next(2);
                    Console.WriteLine("random: " + num);
                    switch (num)
                    {
                        case 0:
                            headcount++;
                            break;
                        case 1:
                            tailcount++;
                            break;
                    }
                }
                Console.WriteLine("\nNumber of Heads: " + headcount);
                Console.WriteLine("Number of Tails: " + tailcount);

                HeadPercentage = (headcount * 100) / Coin;
                tailPercentage = (tailcount * 100) / Coin;
                Console.WriteLine("\nHeadpercentage: " + HeadPercentage + "%");
                Console.WriteLine("tailpercentage: " + tailPercentage + "%");
            }
            else
            {
                Console.WriteLine("Enter a valid Number");
            }
        }
    }
}

