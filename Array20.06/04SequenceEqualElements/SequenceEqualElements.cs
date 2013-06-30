using System;
//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

    class SequenceEqualElements
    {
        static void Main()
        {
            int[] testArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int tempMax = 1;
            int max = 0;
            int maxIndex = 0;
            for (int n = 0; n < testArray.Length-1; n++)
            {
                if (testArray[n] == testArray[n + 1])
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
                    maxIndex = n+1;
                }
            }
            Console.WriteLine("The maximal sequence of equal elements in the array: ");
            for (int n = (maxIndex - max+1); n <=(maxIndex); n++)
            {
                Console.Write("{0} ",testArray[n]);
            }
            Console.WriteLine();
        }
    }

