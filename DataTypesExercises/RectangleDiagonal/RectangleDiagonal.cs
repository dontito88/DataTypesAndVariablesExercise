﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            var a = float.Parse(Console.ReadLine());
            var b = float.Parse(Console.ReadLine());
            float perimeter = (2 * a) + (2 * b);
            float area = a * b;
            double diagonal = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}