using System;
//Write a program that finds the sequence of maximal sum in given array. Example:
//	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//	Can you do it with only one loop (with single scan through the elements of the array)?

    class Program
    {
        static void Main()
        {
            int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int tempSum = arr[0];
            int maxSum = arr[0];
            int maxStart = 0;
            int maxEnd = 0;
            for (int n = 0; n <arr.Length; n++)
            {
                for (int m = n; m < arr.Length; m++)
                {
                    tempSum = tempSum + arr[m];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxStart = n;
                        maxEnd = m;
                    }
                   
                }
                tempSum = arr[0];
            }
            for (int n = maxStart; n <= maxEnd; n++)
            {
                Console.Write("{0} ",arr[n]);
            }
            Console.WriteLine();
        }
    }

