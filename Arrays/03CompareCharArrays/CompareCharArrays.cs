//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).
using System;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Enter a length for the first array:");
        int n = int.Parse(Console.ReadLine());
        char[] firstArray = new char[n];
        //char[] firstArray = new char[]{a,b,c};
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("first[{0}]=", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter a length for the second array:");
        int m = int.Parse(Console.ReadLine());
        char[] secondArray = new char[m];
        //char[] secondArray = new char[]{a,b,c};
        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("second[{0}]=", i);
            secondArray[i] = char.Parse(Console.ReadLine());
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

