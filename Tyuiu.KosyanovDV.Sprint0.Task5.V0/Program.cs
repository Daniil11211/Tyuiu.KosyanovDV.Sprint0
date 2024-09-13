using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KosyanovDV.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KosyanovDV.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(8, 9));
            Console.WriteLine("A + B = " + DataService.Substraction(10, 9));
            Console.WriteLine("A + B = " + DataService.Multiplication(8, 9));
            Console.WriteLine("A + B = " + DataService.Division(36, 9));
            Console.ReadKey();
        }
    }
}