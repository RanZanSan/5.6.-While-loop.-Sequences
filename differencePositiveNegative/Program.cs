using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace differencePositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sumPositive = 0;
            int sumNegative = 0;

            while (n != 0)
            {
                if (n > 0)
                {
                    sumPositive++;
                }
                else
                {
                    sumNegative++;
                }

                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(sumPositive - sumNegative);
            Console.ReadKey();
        }
    }
}