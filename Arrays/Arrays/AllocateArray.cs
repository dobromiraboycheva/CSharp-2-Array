//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class AllocateArray
{
    static void Main()
    {
        int n = 20;
        int[] array=new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("array[{0}]={1}", i, array[i]);
        }
    }
}

