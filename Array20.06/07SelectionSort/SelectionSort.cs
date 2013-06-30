using System;
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the "selection sort" algorithm: Find the smallest element, move it at the first position,
//find the smallest from the rest, move it at the second position, etc.

    class SelectionSort
    {
        static void Main()
        {
            int?[] testArr = {2, 3, -6, -1, 2, -1, 6, 4, -8, 8};
            int?[] sorted = new int? [testArr.Length];
            int? max = testArr[0];
            for (int n = 0; n < testArr.Length; n++)
            {
                if (max < testArr[n])
                {
                    max = testArr[n];
                }
            }
            int? min = max;
            for (int n = 0; n < testArr.Length; n++)
            {
                for (int m = 0; m < testArr.Length; m++)
                {
                    if (testArr[m] <= min)
                    {
                        min = testArr[m];
                    }
                }
                sorted[n] = min;
                for (int m = 0; m < testArr.Length; m++)
                {
                    if (testArr[m] == min)
                    {
                        testArr[m] = null;
                        break;
                    }
                }
                min = max;
            }
            for (int m = 0; m < testArr.Length; m++)
            {
                Console.Write("{0} ",sorted[m]);
            }
            Console.WriteLine();
        }
    }

