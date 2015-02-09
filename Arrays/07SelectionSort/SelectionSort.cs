//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        double[] array = new double[n];
        // double[] array = new double[]{8,11,6,4,2,6};
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = double.Parse(Console.ReadLine());
        }

        double minElement = array[0];
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
            double temp = array[i];
            array[i] = array[index];
            array[index] = temp;
        }
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

