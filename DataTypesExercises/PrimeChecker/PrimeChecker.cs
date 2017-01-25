using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            for (int number = 2; number <= input; number++)
            {
                bool checker = true;
                for (int area = 2; area <= Math.Sqrt(number); area++)
                {
                    if (number % area == 0)
                    {
                        checker = false;
                        break;
                    }

                }
                Console.WriteLine($"{number} -> {checker}");
            }
        }
    }
}
