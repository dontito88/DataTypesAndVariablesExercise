using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            if (input == "true")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
