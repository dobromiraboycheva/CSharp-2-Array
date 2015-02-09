//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input                             	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	    2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?
using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        //int[] array = new int[]{2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = int.MinValue;
        int currentsum = int.MinValue;
        int startIndexer=0 , index=0, endIndex=0;
        for (int i = 0; i < array.Length; i++)
        {
            if(currentsum<=0)
            {
                startIndexer = i;
                currentsum = 0;
            }
            currentsum += array[i];
            if(currentsum>sum)
            {
                sum = currentsum;
                index = startIndexer;
                endIndex = i;
            }
        }
        for (int i = index; i <= endIndex; i++)
        {
            Console.Write(i!=endIndex ? array[i]+", " : array[i]+"\n");
        }
    }
}

