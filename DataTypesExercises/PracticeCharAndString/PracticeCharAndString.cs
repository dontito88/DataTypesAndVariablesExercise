using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCharAndString
{
    class PracticeCharAndString
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            var third = char.Parse(Console.ReadLine());
            string end = Console.ReadLine();

            Console.WriteLine(title);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(end);
        }
    }
}
