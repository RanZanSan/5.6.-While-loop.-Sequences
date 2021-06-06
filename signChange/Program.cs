using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int numberToo = number;
            int count = 0;

            while(number != 0)
            {
                if(number * numberToo < 0)
                {
                    count++;
                }

                numberToo = number;
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}