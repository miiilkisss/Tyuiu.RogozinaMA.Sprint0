using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.RogozinaMA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.RogozinaMA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
           
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
         
            Console.WriteLine("Разность злементов массива = " + DataService.SubtractionArray(numsArray));
           
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
