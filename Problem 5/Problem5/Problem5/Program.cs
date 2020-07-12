using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList output = new ArrayList();
            long result = 1;

            Console.Write("n = ");
            int max = int.Parse(Console.ReadLine());

            for (int i = 2; i <= max; i++)
            {
                Factorise(i, output);
            }

            output.Sort();

            for (int j = 0; j < output.Count; j++)
            {
                result = result * long.Parse(output[j].ToString());
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static void Factorise(int number, ArrayList output)
        {
            ArrayList copy = (ArrayList)output.Clone();

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (!RemoveOneObject(i, copy))
                    {
                        output.Add(i);
                    }
                    number = number / i;
                    i--;
                }
            }
        }

        private static bool RemoveOneObject(int number, ArrayList list)
        {
            if (list.Contains(number))
            {
                list.RemoveAt(removeAtIndex(number, list));
                return true;
            }
            return false;
        }

        private static int removeAtIndex(int number, ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}