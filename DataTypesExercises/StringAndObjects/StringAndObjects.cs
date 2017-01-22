using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObjects
{
    class StringAndObjects
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            string concatenatedWords = firstWord + " " + secondWord;
            Console.WriteLine(concatenatedWords);
        }
    }
}
