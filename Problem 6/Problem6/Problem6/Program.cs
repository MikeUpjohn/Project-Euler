using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int sumOfSquares = 0;
            int squareOfSum = 0;
            int result;

            Console.Write("Max Value: ");
            int max = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i++)
            {
                sumOfSquares += (i * i);
            }

            for (int i = 0; i <= 100; i++)
            {
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;

            result = squareOfSum - sumOfSquares;

            Console.WriteLine("Sum of Square: " + sumOfSquares);
            Console.WriteLine("Square of Sum: " + squareOfSum);
            Console.WriteLine("Result: " + result);*/

            int sumOfSquares = 0;
            int squareOfSum = 0;
            int number = 0;
            int result = 0;

            Console.Write("Number: ");
            number = int.Parse(Console.ReadLine());

            sumOfSquares = number * (number + 1) * ((2 * number) + 1) / 6;
            squareOfSum = (int)Math.Pow((number * (number + 1) / 2), 2);

            result = squareOfSum - sumOfSquares;
            Console.WriteLine("Result: " + result);
        }
    }
}
