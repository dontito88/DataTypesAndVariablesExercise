using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeFloatingPointNumbers
{
    class PracticeFloatingPointNumbers
    {
        static void Main(string[] args)
        {
            var firstNumber = decimal.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());
            var thirdNumber = decimal.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
        }
    }
}
