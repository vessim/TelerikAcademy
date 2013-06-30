using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

    class MaxSumKElements
    {
        static void Main()
        {
            Console.WriteLine("Please input integer N");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input integer K");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            for (int n = 0; n < len; n++)
            {
                Console.WriteLine("Element {0}: ",n);
                arr[n] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int n = 0; n < k; n++)
            {
                sum = sum + arr[n];
            }
            int tempSum = 0;
            int maxSum = sum;
            int maxIndex = 0;
            for (int n = 0; n < (len - k); n++)
            {
                for (int m = n; m < n + k; m++)
                {
                    tempSum = tempSum + arr[m];
                }
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    maxIndex = n;
                }
                tempSum = 0;
            }
            //print
            for (int n = maxIndex; n < (maxIndex + k); n++)
            {
                Console.Write("{0} ",arr[n]);
            }
            Console.WriteLine();
        }
    }

