using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 999; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            Console.WriteLine("Result: " + sum);
            Console.ReadLine();
        }
    }
}
