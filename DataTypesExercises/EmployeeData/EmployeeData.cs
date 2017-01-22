using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string family = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());
            var ID = double.Parse(Console.ReadLine());
            var uniEmpNumber = double.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {name}\nLast name: {family}\nAge: {age}\nGender: {gender}\nPersonal ID: {ID}\nUnique Employee number: {uniEmpNumber}");
        }
    }
}
