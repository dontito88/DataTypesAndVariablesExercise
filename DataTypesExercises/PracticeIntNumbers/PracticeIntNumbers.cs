﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIntNumbers
{
    class PracticeIntNumbers
    {
        static void Main(string[] args)
        {
            var num1 = short.Parse(Console.ReadLine());
            var num2 = byte.Parse(Console.ReadLine());
            var num3 = short.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());
            var num5 = long.Parse(Console.ReadLine());
            var num6 = double.Parse(Console.ReadLine());
            var num7 = decimal.Parse(Console.ReadLine());

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
        }
    }
}
