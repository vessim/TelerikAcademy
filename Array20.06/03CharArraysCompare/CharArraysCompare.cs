using System;

//Write a program that compares two char arrays lexicographically (letter by letter).

    class CharArraysCompare
    {
        static void Main()
        {
            Console.WriteLine("Please input the length of the arrrays");
            int len = int.Parse(Console.ReadLine());
            char[] arr1 = new char[len];
            char[] arr2 = new char[len];
            for (int n = 0; n < len; n++)
            {
                Console.WriteLine("Array 1 Index {0}", n);
                string temp = Console.ReadLine();
                arr1[n] = temp[0];

            }
            for (int n = 0; n < len; n++)
            {

                Console.WriteLine("Array 2 Index {0}", n);
                string temp = Console.ReadLine();
                arr2[n] = temp[0];
            }

            for (int n = 0; n < len; n++)
            {
                if (arr1[n] > arr2[n])
                {
                    Console.WriteLine("Element {0} in the first arrray is bigger", n);
                }
                else if (arr1[n] < arr2[n])
                {
                    Console.WriteLine("Element {0} in the second arrray is bigger", n);
                }
                else
                {
                    Console.WriteLine("Element {0} in the first arrray is equal to element {0} in the second array", n);
                }
            }
        }
    }

