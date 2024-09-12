using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuyiu.KosyanovDV.Sprint0.Task2.V0.Lib;

namespace Tuyiu.KosyanovDV.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine(DataService.GetMessage("Даниил"));
            Console.ReadKey();
        }
    }
}