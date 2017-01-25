using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntToHexAndBinar
{
    class IntToHexAndBinar
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(input, 16);
            string binary = Convert.ToString(input, 2);
            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary.ToUpper());
        }
    }
}
