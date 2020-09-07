using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1_GCD;

namespace Task1_UI_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.MaxValue;
            int b = 1;
            long time;
            Console.WriteLine($"{a}, {b} =>{GCD.EuclidAlgorithm(a, b, out time)} =>{time}ms");
            Console.WriteLine($"{a}, {b} =>{GCD.SteinAlgorithm(a, b, out time)} =>{time}ms");
            Console.ReadLine();
        }
    }
}
