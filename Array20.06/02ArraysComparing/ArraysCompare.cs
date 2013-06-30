using System;

//Write a program that reads two arrays from the console and compares them element by element.

    class ArraysCompare
    {
        static void Main()
        {
            Console.WriteLine("Please input the length of the arrrays");
            int len = int.Parse(Console.ReadLine());
            int[] arr1 = new int[len];
            int[] arr2 = new int[len];
            for (int n = 0; n < len; n++)
            {
                Console.WriteLine("Array 1 Index {0}", n);
                arr1[n] = int.Parse(Console.ReadLine());
                
            }
            for (int n = 0; n < len; n++)
            {
               
                Console.WriteLine("Array 2 Index {0}", n);
                arr2[n] = int.Parse(Console.ReadLine());
               
            }
          
            for (int n = 0; n < len; n++)
            {
                if (arr1[n] > arr2[n])
                {
                    Console.WriteLine("Element {0} in the first arrray is bigger",n);
                }
                else if (arr1[n] < arr2[n])
                {
                    Console.WriteLine("Element {0} in the second arrray is bigger",n);
                }
                else
                {
                    Console.WriteLine("Element {0} in the first arrray is equal to element {0} in the second array",n);
                }
            }
        }
    }

