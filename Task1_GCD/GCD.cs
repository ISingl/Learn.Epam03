using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_GCD
{
    public class GCD
    {
        /// <summary>
        /// The Euclidean algorithm is an efficient method for computing the greatest common divisor (GCD) of two integers (numbers),
        /// the largest number that divides them both without a remainder.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <returns>Greatest common divisor</returns>
        public static int EuclidAlgorithm(int a, int b)
        {
            if (a == 0 && b == 0) throw new DivideByZeroException();
            if (a == b || b == 0) return a;
            if (a == 0) return b;

            if (a < 0) a *= -1;
            if (b < 0) b *= -1;

            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }

        /// <summary>
        /// The Euclidean algorithm is an efficient method for computing the greatest common divisor (GCD) of two integers (numbers),
        /// the largest number that divides them both without a remainder.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <param name="c">The third integer</param>
        /// <returns>Greatest common divisor</returns>
        public static int EuclidAlgorithm(int a, int b, int c)
        {
            return EuclidAlgorithm(new int[] { a, b, c });
        }

        /// <summary>
        /// The Euclidean algorithm is an efficient method for computing the greatest common divisor (GCD) of two integers (numbers),
        /// the largest number that divides them both without a remainder.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <param name="c">The third integer</param>
        /// <param name="d">The fourth integer</param>
        /// <returns>Greatest common divisor</returns>
        public static int EuclidAlgorithm(int a, int b, int c, int d)
        {
            return EuclidAlgorithm(new int[] { a, b, c, d });
        }

        /// <summary>
        /// The Euclidean algorithm is an efficient method for computing the greatest common divisor (GCD) of two integers (numbers),
        /// the largest number that divides them both without a remainder.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <param name="c">The third integer</param>
        /// <param name="d">The fourth integer</param>
        /// <param name="e">The fifth integer</param>
        /// <returns>Greatest common divisor</returns>
        public static int EuclidAlgorithm(int a, int b, int c, int d, int e)
        {
            return EuclidAlgorithm(new int[] { a, b, c, d, e });
        }

        private static int EuclidAlgorithm(params int[] numbers)
        {
            if (numbers.Length == 0) throw new ArgumentNullException();
            if (numbers.Length == 1) return numbers[0];

            int tmp = numbers[0];
            foreach (int value in numbers)
                tmp = EuclidAlgorithm(tmp, value);

            return tmp;
        }

        /// <summary>
        /// The binary GCD algorithm, also known as Stein's algorithm, 
        /// is an algorithm that computes the greatest common divisor of two nonnegative integers.
        /// </summary>
        /// <param name="a">The first integer</param>
        /// <param name="b">The second integer</param>
        /// <returns>Greatest common divisor</returns>
        public static int SteinAlgorithm(int a, int b)
        {
            if (a == 0 && b == 0) throw new DivideByZeroException();
            if (a == b || b == 0) return a;
            if (a == 0) return b;

            bool aIsEven = (a & 1u) == 0;
            bool bIsEven = (b & 1u) == 0;

            if (aIsEven && bIsEven)
                return SteinAlgorithm(a >> 1, b >> 1) << 1;
            else if (aIsEven && !bIsEven)
                return SteinAlgorithm(a >> 1, b);
            else if (bIsEven)
                return SteinAlgorithm(a, b >> 1);
            else if (a > b)
                return SteinAlgorithm((a - b) >> 1, b);
            else
                return SteinAlgorithm(a, (b - a) >> 1);
        }
    }
}
