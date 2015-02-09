//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

using System;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("Enter a length for the first array:");
        int n = int.Parse(Console.ReadLine());
        int[] Array = new int[n];
        //int[] Array = new int[]{2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write("element[{0}]=", i);
            Array[i] = int.Parse(Console.ReadLine());
        }

        int currentLength = 1;
        int currentElement=Array[0];
        int bestElement=0;
        int bestLength=0;
        if(Array.Length==1)
        {
            bestElement = currentElement;
            bestLength = currentLength;
        }
        for (int i = 1; i < Array.Length; i++)
        {
            if(Array[i]==currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = Array[i];
                currentLength = 1;
            }
            if(currentLength>bestLength)
            {
                bestElement = currentElement;
                bestLength = currentLength;
            }
        }
        Console.Write("The maximal sequence of equal elements in the array is: {");
        for (int i = 0; i < bestLength; i++)
        {
            
            Console.Write(i != bestLength - 1 ? bestElement + ", " : bestElement + "}\n");
        }
    }
}

