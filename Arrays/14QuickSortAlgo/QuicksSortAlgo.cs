//Problem 14. Quick sort

//Write a program that sorts an array of strings using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;

class QuicksSortAlgo
{
    static void Main()
    {
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        // int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        QuickSort(array, 0, array.Length - 1);
        for (int k = 0; k < array.Length; k++)
        {
            Console.Write(k < array.Length-1 ? array[k] + ", " : array[k] + "\n");
        }
    }
    static void QuickSort(int[] elements, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(elements, left, right);

            if (pivot > 1)
                QuickSort(elements, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort(elements, pivot + 1, right);
        }
    }
    static public int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];
        while (true)
        {
            while (array[left] < pivot)
                left++;

            while (array[right] > pivot)
                right--;

            if (left < right)
            {
                int temp = array[right];
                array[right] = array[left];
                array[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}

