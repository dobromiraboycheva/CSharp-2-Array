//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter idex of element K=");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        // int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(BinSearch(array, k));
    }
    static int BinSearch(int[] array, int k)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (last >= first)
        {
            int midpoint = (first + last) / 2;
            if (array[midpoint] < k)
            {
                first = midpoint + 1;
            }
            else if (array[midpoint] > k)
            {
                last = midpoint - 1;
            }
            else
            {
                return midpoint;
            }
        }
        return -1;
    }
}
