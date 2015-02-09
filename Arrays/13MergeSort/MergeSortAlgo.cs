//Problem 13.* Merge sort

//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class MergeSortAlgo
{
    static void Main()
    {
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int[] temp = new int[n];
        // int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        MergeSort(array, temp, 0, array.Length - 1);
        for (int k = 0; k < array.Length; k++)
        {
          Console.Write(k < array.Length-1 ? array[k] + ", " : array[k] + "\n");  
        }
    }
    static void MergeSort(int[] elements, int[] temp, int start, int end)
    {
        if (start >= end) return; 

        int middle = start + (end - start) / 2; 

        MergeSort(elements, temp, start, middle);
        MergeSort(elements, temp, middle + 1, end);
       int i = start; 
        int l = start, m = middle + 1;
        while (l <= middle && m <= end)
        {
            temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];
        }
        while (l <= middle)
        {
            temp[i++] = elements[l++];
        }
        while (m <= end)
        {
            temp[i++] = elements[m++];
        }
        for (int j = start; j <= end; j++)
        {
            elements[j] = temp[j];
        }
    }
}

   