using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalConvert
{
    class HexadecimalConvert
    {
        static void Main(string[] args)
        {
            string hexaNumber = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexaNumber, 16));
        }
    }
}
