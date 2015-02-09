//Problem 17.* Subset K with sum S

//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter how many subset of elemnts will be search K=");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter sum that will be find S=");
        int s = int.Parse(Console.ReadLine());
        //int s = 14;
        Console.Write("Enter how many element will be in the array N=");
        int n = int.Parse(Console.ReadLine());
        if(k>n)
        {
            Console.WriteLine("Element in array are less then subset elements for sum K<={0}",n);
            Console.Write("K=");
            k = int.Parse(Console.ReadLine());
        }
        // int[] array = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        int counter = 0;
        string[] parseBinnary = new string[n];
        for (int i = 1; i < (int)Math.Pow(2, n); i++)
        {
            string bin = Convert.ToString(i, 2).PadLeft(n, '0');
            for (int j = 0; j < k; j++)
            {
                parseBinnary[j] = Convert.ToString(bin[j]);
                sum = sum + int.Parse(parseBinnary[j]) * array[j];
            }
            if (sum == s)
            {
                counter++;
            }
            sum = 0;
        }
        if (counter > 0)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}

