using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            Console.Write("nth Prime number to find: ");
            int number = int.Parse(Console.ReadLine());

            result = FindnthPrimeNumber(number);

            Console.WriteLine("Prime number " + number + " is: " + result);
        }

        /// <summary>
        /// Finds the nth prime number
        /// </summary>
        /// <param name="primeNumber">The nth prime number to find</param>
        /// <returns>The prime number</returns>
        public static int FindnthPrimeNumber(int primeNumber)
        {
            bool isPrime;
            int counter = 1;
            int result = 0;
            int[] primes = { 2 };
            int middlePrime = 0;
            

            Console.WriteLine("Prime: 2");

            for (int i = 3; counter < primeNumber; i += 2)
            {
                isPrime = true;
                middlePrime = GetMiddlePrimeIndex(primes, i);
                /*for (int j = 2; (j < i) && isPrime; j++)
                {*/
                for (int j = 0; j < middlePrime; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime: " + i);
                    primes = UpdateArray(primes, i);
                    counter++;
                }
                result = i;
            }

            return result;

            /*for (int s = 0; s < primes.Length; s++)
            {
                Console.WriteLine(primes[s].ToString());
            }*/
        }

        /// <summary>
        /// Take the current array of prime numbers, re-size it one bigger and add the new value to the end.
        /// In this context, this ensure the array is always sorted in numerical order.
        /// </summary>
        /// <param name="array">The array to be added to.</param>
        /// <param name="newValue">The new integer value to add to the array.</param>
        /// <returns>The new array with the added value.</returns>
        public static int[] UpdateArray(int[] array, int newValue)
        {
            int oldSize = array.Length;

            int[] newArray = new int[oldSize+1];

            for (int i = 0; i < oldSize; i++)
            {
                newArray[i] = array[i];
            }

            newArray[newArray.Length - 1] = newValue;

            return newArray;
        }

        /// <summary>
        /// Returns the index in the array of the location where the value first becomes greater than the next value to be tested divide by two.
        /// This is true such that prime numbers can only be divisible by numbers between 2 and the half the new numbers.
        /// </summary>
        /// <param name="array">The array to find the central index of.</param>
        /// <param name="j">The new integer value which determines the last possible value that could cause this number not to be prime.</param>
        /// <returns></returns>
        public static int GetMiddlePrimeIndex(int[] array, int j)
        {
            int maxIterativeValue = (int)Math.Round((double)(j / 2), 0) + 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxIterativeValue)
                {
                    return i;
                }
            }
            return array.Length;
        }
    }
}
