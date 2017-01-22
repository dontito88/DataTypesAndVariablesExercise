using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseCharacters
{
    class ReverseCharacters
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            var thirdChar = char.Parse(Console.ReadLine());

            Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");
        }
    }
}
