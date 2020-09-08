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
            Console.Write("Greatest common divisor\nInput two numbers using a space and press enter: ");
            var tmp = Console.ReadLine().Split(' ');
            if (tmp.Length < 2) return;
            if (!Int32.TryParse(tmp[0], out int a)) return;
            if (!Int32.TryParse(tmp[1], out int b)) return;

            Console.WriteLine($"\n{String.Format(new string('=', 50))}\n" +
                $"Euclidean algorithm: {a}, {b} => GCD: {GCD.EuclidAlgorithm(a, b, out long time)} => WorkTime: {time}ms\n" +
                $"Stein's algorithm: {a}, {b} => GCD: {GCD.SteinAlgorithm(a, b, out time)} => WorkTime: {time}ms");

            Console.ReadLine();
        }
    }
}
