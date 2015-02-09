//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input                 	result
//3, 2, 3, 4, 2, 2, 4	    2, 3, 4
using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.WriteLine("Enter a length for the first array:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        //int[] array = new int[]{3, 2, 3, 4, 2, 2, 4};
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        List<int> currentSequance = new List<int>() { array[0]};
        List<int> bestSequence = new List<int>();
        int currElement = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i]>currElement)
            {
                currentSequance.Add(array[i]);
                currElement = array[i];
            }
            else 
            {
                currElement = array[i];
                currentSequance=new List<int>(){array[i]};
            }
            if (currentSequance.Count > bestSequence.Count)
            {
                bestSequence = currentSequance;
            }
        }
        for (int i = 0; i < bestSequence.Count; i++)
        {
            if (i < bestSequence.Count - 1)
            {
                Console.Write(bestSequence[i] + ", ");
            }
            else
            {
                Console.Write(bestSequence[i]);
            }
        }
        Console.WriteLine();
    }
}

