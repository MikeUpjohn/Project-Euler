using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfEven = 0;
            int a = 1;
            int b = 2;
            int c = 0;

            Console.Write("Stop looping when even valued terms sum exceeds: ");
            long max = long.Parse(Console.ReadLine());

            while (c < max)
            {
                c = a + b;

                if (c % 2 == 0)
                {
                    sumOfEven += c;
                }

                a = b;
                b = c;
            }
            sumOfEven += 2;

            Console.WriteLine("Sum: " + sumOfEven);
            Console.ReadLine();
        }
    }
}
