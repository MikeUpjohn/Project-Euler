using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9
{
    class Program
    {
        /*static void Main(string[] args) {
            // Define variables

            // Loop variable a from 0 to 332.
            // Loop variable b from 0 to less than a.
            // Loop variable c from 0 to less than b.
            // Test if a2 + b2 = c2
            // If it is, test if a + b + c is 1000
            // If it is WIN!

            int a = 0;
            int b = 0;
            int c = 0;
            bool loop = true;
            int result = 0;

            for (c = 0; (c < 1000) && loop ; c++)
            {
                for (b = 0; (b < c) && loop; b++)
                {
                    for (a = 0; (a < b) && loop; a++)
                    {
                        Console.WriteLine("c: " + c + ", b: " + b + ", a:" + a);

                        if (a == 3 && b == 4 && c == 5)
                        {
                            int z = 0;
                            z++;
                        }
                        if (IsPythagoreanTriplet(a, b, c))
                        {
                            int y = 0;
                            y++;

                            if (AreSomeOfSidesAGivenNumber(a, b, c, 1000))
                            {
                                result = FindProductOfSidesOfTriangle(a, b, c);
                                loop = false;
                            }
                        }
                    }
                }
            }

            if (!loop)
            {
                Console.WriteLine("Pythagorean Triplet {" + a + ", " + b + ", " + c + " evaluates to " + result);
            }
        //}

        /// <summary>
        /// Calculates and decides whether a2 and b2 are equal to c2.
        /// e.g. a=1, b=1,c=7 is invalid, but a=3, b=4 and c=5 is valid.
        /// </summary>
        /// <param name="a">The length of the first side.</param>
        /// <param name="b">The length of the second side.</param>
        /// <param name="c">The length of the hypotenuse.</param>
        /// <returns>True if a2 + b2 = c2, else false.</returns>
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Test to see if three given numbers sum to a fourth given number.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <param name="c">The third value.</param>
        /// <param name="number">The number to sum to.</param>
        /// <returns>True if a, b and c sum to number, else false.</returns>
        public static bool AreSomeOfSidesAGivenNumber(int a, int b, int c, int number)
        {
            if (a + b + c == number)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Return the product of three values, representing the sides of a triangle.
        /// </summary>
        /// <param name="a">The first side.</param>
        /// <param name="b">The second side.</param>
        /// <param name="c">The third side.</param>
        /// <returns>The product of the three values.</returns>
        public static int FindProductOfSidesOfTriangle(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}
