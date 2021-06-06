using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buildingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int cnt = 0;

            while (n != 0)
            {
                cnt++;
                n = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}