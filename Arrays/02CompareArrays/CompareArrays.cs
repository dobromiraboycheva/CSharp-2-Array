//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.

using System;
using System.Linq;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Enter a length for the first array:");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        //int[] firstArray = new int[]firstArray={0,1,2};
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("first[{0}]=", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter a length for the second array:");
        int m = int.Parse(Console.ReadLine());
        int[] secondArray = new int[m];
        //int[] secondArray = new int[]{0,1,2};
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("second[{0}]=", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        if (firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("The first array is bigger then the second array!");
        }
        else if (firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("The second array is bigger then the first array!");
        }
        else if (firstArray.Length == secondArray.Length)
        {
            int count = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    break;
                }
                else
                {
                    count++;
                }
            }
            if (count < firstArray.Length)
            {
                Console.WriteLine("The first array and the second array have equal length but different elements!");
            }
            else
            {
                Console.WriteLine("The first array and the second array have equal length and equal elements!");
            }
        }
    }
}

