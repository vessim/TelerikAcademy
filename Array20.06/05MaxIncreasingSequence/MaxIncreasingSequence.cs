using System;
//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

 class MaxIncreasingSequence
    {
        static void Main()
        {
            int[] testArray = { 3, 2, 3, 4, 2, 2, 4 };
            int tempMax = 1;
            int max = 0;
            int maxIndex = 0;
            for (int n = 0; n < testArray.Length - 1; n++)
            {
                if ((testArray[n]+1) == testArray[n + 1])
                {
                    tempMax++;
                }
                else
                {
                    tempMax = 1;
                }
                if (tempMax > max)
                {
                    max = tempMax;
                    maxIndex = n + 1;
                }
            }
            Console.WriteLine("The maximal increasing sequence in the array: ");
            for (int n = (maxIndex - max + 1); n <= (maxIndex); n++)
            {
                Console.Write("{0} ", testArray[n]);
            }
            Console.WriteLine();
        }
    }

