﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tyuiu.KosyanovDV.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;
            while (index < numbers.Length)
            {
                total += numbers[index];
                index++;
            }
            return total;
        }

        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            var index = 0;
            while (index < numbers.Length)
            {
                total *= numbers[index];
                index++;
            }
            return total;
        }
    }
}
        
           
    

