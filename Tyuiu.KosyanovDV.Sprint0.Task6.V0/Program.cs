using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KosyanovDV.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KosyanovDV.Sprint0.Task6.V0.Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива - " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Вычитание элементов массива - " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива - " + DataService.MultiplicationArray(arraynums));
        }
    }
}
