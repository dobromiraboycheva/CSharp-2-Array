//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter how many elemets will be in array N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter how many elements will create your sum K=");
        int k = int.Parse(Console.ReadLine());
        if(n<k)
        {
            Console.WriteLine("The length of elements in array must be more or equal of elements in subset sum! K<={0}",n);
            Console.Write("Enter K=");
            k = int.Parse(Console.ReadLine());
        }
        List<int> array = new List<int>();
        //List<int> array = new List<int>(){2,77,59,77,11,5,6};
        for (int i = 0; i < n; i++)
        {
            Console.Write("element[{0}]=",i);
            array.Add(int.Parse(Console.ReadLine()));
        }
        array.Sort();
        long sum = 0;
        for (int i = array.Count-1; i >array.Count-1-k; i--)
        {
            sum += array[i];
        }
        Console.WriteLine("Max sum of {0} elements in array is={1}",k,sum);
    }
}

