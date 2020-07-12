using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxPalindrome = 0;
            int sum;
            string sumString;
            int stringLength;
            int centerStartingPoint;
            string a = "";
            string b = "";
            ArrayList result = new ArrayList();
            char[] reverseString;
            TextWriter text = new StreamWriter("output.txt");

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    sum = i * j;

                    if (sum == 99900)
                    {
                        int A = 1;
                        A++;
                    }
                    sumString = sum.ToString();

                    stringLength = sumString.Length;

                    if (stringLength % 2 == 0)
                    {
                        centerStartingPoint = stringLength / 2;
                        a = sumString.Substring(0, centerStartingPoint);
                        b = sumString.Substring(centerStartingPoint, centerStartingPoint);
                    }
                    else
                    {
                        centerStartingPoint = (stringLength / 2) + 1;
                        a = sumString.Substring(0, centerStartingPoint - 1);
                        b = sumString.Substring(centerStartingPoint, centerStartingPoint - 1);
                    }

                    reverseString = new char[b.Length];
                    reverseString = b.ToCharArray();

                    for (int z = 0; z < b.Length; z++)
                    {
                        reverseString[z] = b[b.Length - z -1];
                    }

                    b = new string(reverseString);

                    if (a.Equals(b))
                    {
                        result.Add(sum);
                    }
                }
            }

            #region print all palindromes
            foreach (int i in result)
            {
                Console.WriteLine("Palindrome: " + i);
                text.WriteLine("Palindrome: " + i);
            }
            #endregion

            #region print highest palindrome
            foreach (int i in result)
            {
                if (i > maxPalindrome)
                {
                    maxPalindrome = i;
                }
            }
            Console.WriteLine("Max Palindrome: " + maxPalindrome);
            text.WriteLine("Max Palindrome: " + maxPalindrome);
            #endregion

            Console.ReadLine();
        }
    }
}
