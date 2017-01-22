using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: \na = {a} \nb = {b}");
            int temp = 0;
            temp += b;
            b = a;
            Console.WriteLine($"After: \na = {temp} \nb = {b}");
        }
    }
}
