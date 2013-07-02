using System;
//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

   class AlphabetArray
    {
        static void Main()
        {
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            Console.WriteLine("Please input word");
            string word = Console.ReadLine();
            for (int n = 0; n < word.Length; n++)
            {
                char search=word[n];
                for (int m = 0; m < 26; m++)
                {
                    if (alphabet[m] == search)
                    {
                        Console.Write("{0} ",m);
                    }
                }
            }
            Console.WriteLine();
        }
    }

