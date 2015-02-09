//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        // int[] array = new int[] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            int index = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[index] >= array[j])
                {
                    index = j;
                }
            }
            int temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
        int count = 1, currentCount = 1;
        int number = array[0];
        int currentNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (currentNumber == array[i])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > count)
                {
                    count = currentCount;
                    number = currentNumber;
                }
                currentCount = 1;
                currentNumber = array[i];
            }
            if (currentCount > count)
            {
                count = currentCount;
                number = currentNumber;
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} ({1}times)", number, count);
    }
}

