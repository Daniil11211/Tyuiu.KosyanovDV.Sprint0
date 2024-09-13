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
        static void Main(string[] args) {
            Console.WriteLine(DataService.Addition(78,89));
            Console.WriteLine(DataService.Substraction(89, 89));
            Console.WriteLine(DataService.Multiplication(9, 2));
            Console.WriteLine(DataService.Division(36, 6));
            Console.ReadKey();
        }
    }
}
