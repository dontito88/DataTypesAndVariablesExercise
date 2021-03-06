﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverSpeedUnits
{
    class ConverSpeedUnits
    {
        static void Main(string[] args)
        {
            var distance = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            double speedMeterPerSecond = distance / seconds;
            double speedKmPerHour = (distance / 1000) / hour;
            double speedMilePerHour = ((distance / 1000) * 1609) / hour;

            Console.WriteLine(speedMeterPerSecond);
            Console.WriteLine(speedKmPerHour);
            Console.WriteLine(speedMilePerHour);
        }
    }
}