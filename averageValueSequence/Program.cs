using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageValueSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;

            while(number != 0)
            {
                sum += number;
                count++;
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine((double)sum / count);
            Console.ReadKey();
        }
    }
}