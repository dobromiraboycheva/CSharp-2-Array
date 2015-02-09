//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabetUpper = new char[26];
        for (int i = 0; i < alphabetUpper.Length; i++)
        {
            alphabetUpper[i] = (char)(i + 65);
        }
        //char[] alphabetLower = new char[26];
        //for (int i = 0; i < alphabetLower.Length; i++)
        //{
        //    alphabetLower[i] = (char)(i + 97);
        //}
        //foreach (var item in alphabetUpper)
        //{
        //    Console.WriteLine(item);
        //}
        //foreach (var item in alphabetLower)
        //{
        //    Console.WriteLine(item);
        //}
        Console.WriteLine("Enter your word:");
        string word = Console.ReadLine();
        for (int j = 0; j < word.Length; j++)
        {
            for (int i = 0; i < alphabetUpper.Length; i++)
            {
                if (word[j] == alphabetUpper[i])//||word[j] == alphabetLower[i]  
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
