using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int splitLength = 5;
            string number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            int maxProduct = 0;
            int product = 0;

            ArrayList splitString = new ArrayList();
            splitString = SplitNumber(number, splitLength);
            splitString = RemoveZeroValues(splitString);

            for (int i = 0; i < splitString.Count; i++)
            {
                product = CalculateProductOfNumber(splitString[i].ToString());

                if (IsNewMaximumProductFound(product, maxProduct))
                {
                    maxProduct = product;
                }
            }

            Console.WriteLine("Maximum product of the number " + number + " is: " + maxProduct);
        }

        /// <summary>
        /// Split the number up in to given lengths from beginning to end advancing by 1 character each time.
        /// </summary>
        /// <param name="number">The number to be split.</param>
        /// <param name="splitLength">The length of the resulting number split.</param>
        /// <returns>Number: 125616153, SplitLength: 5, would return 12561, 25616, 56161, 61615, 16153.</returns>
        private static ArrayList SplitNumber(string number, int splitLength)
        {
            ArrayList splitString = new ArrayList();

            for (int i = 0; i <= number.Length - splitLength; i++)
            {
                splitString.Add(number.Substring(i, splitLength));
            }

            return splitString;
        }

        /// <summary>
        /// Find and remove all instances of a number containing a zero. Not required for calculation.
        /// </summary>
        /// <param name="numbers">The array of strings to be tested for zero and deleted if appropriate.</param>
        /// <returns>The same array but without any entries that have numbers containing zero.</returns>
        private static ArrayList RemoveZeroValues(ArrayList numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                string value = numbers[i].ToString();

                if (value.Contains('0'))
                {
                    numbers.RemoveAt(i);
                }
            }

            return numbers;
        }

        /// <summary>
        /// Calculate the product of each numeric character in a given string.
        /// </summary>
        /// <param name="number">The string to be multiplied</param>
        /// <returns></returns>
        private static int CalculateProductOfNumber(string number)
        {
            int[] values = SplitOneStringForCalculation(number);
            int sum = FindProduct(values);

            return sum;
        }

        /// <summary>
        /// Splits one string into an array of integers.
        /// </summary>
        /// <param name="number">The string format number to be split.</param>
        /// <returns>An array of the split integers.</returns>
        private static int[] SplitOneStringForCalculation(string number)
        {
            int[] values = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                values[i] = int.Parse(number[i].ToString());
            }
            return values;
        }

        /// <summary>
        /// Find the product of a given set of values.
        /// </summary>
        /// <param name="values">An array of integers to be multiplied.</param>
        /// <returns>The product of all values in the array.</returns>
        private static int FindProduct(int[] values)
        {
            int sum = 1;
            for (int i = 0; i < values.Length; i++)
            {
                sum *= values[i];
            }

            return sum;
        }

        /// <summary>
        /// Test whether the new calculated product is greater than the previous highest found product.
        /// </summary>
        /// <param name="product">The new product.</param>
        /// <param name="maxProduct">The maximum previous product.</param>
        /// <returns>True if the new product exceeds the previous maximum product, else false.</returns>
        private static bool IsNewMaximumProductFound(int product, int maxProduct)
        {
            if (product > maxProduct)
            {
                return true;
            }

            return false;
        }
    }
}
