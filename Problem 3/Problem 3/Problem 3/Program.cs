using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number to factorise: ");
            long value = long.Parse(Console.ReadLine());
            int divisor = 2;
            int counter = 1;

            ArrayList acceptableDivisors = new ArrayList();

            while (divisor <= value)
            {
                if (value % divisor == 0)
                {
                    value /= divisor;
                    acceptableDivisors.Add(divisor);
                    counter++;
                    divisor++;
                }
                else
                {
                    divisor++;
                }
            }

            #region Print all results
            foreach (int i in acceptableDivisors)
            {
                Console.WriteLine("Prime Factor: " + i);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
