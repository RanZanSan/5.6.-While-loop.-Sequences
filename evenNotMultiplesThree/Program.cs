using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenNotMultiplesThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                if(n % 2 == 0 && n % 3 != 0)
                {
                    sum += n;
                }

                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}