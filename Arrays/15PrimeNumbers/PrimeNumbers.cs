//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        bool[] array = new bool[10000000];
        for (int i = 2; i < Math.Sqrt(array.Length); i++)
        {
            if (array[i] == false)
            {
                for (int j = i * i; j < array.Length; j = j + i)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (array[i] == false)
            {
                Console.WriteLine(i);
            }
        }
    }
}

