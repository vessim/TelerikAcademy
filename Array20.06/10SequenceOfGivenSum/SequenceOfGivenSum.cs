using System;
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
    class SequenceOfGivenSum
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
            int s = 11;
            int sum = 0;
            int start = 0;
            int end = 0;
            for (int n = 0; n < arr.Length; n++)
            {
                for (int m = n; m < arr.Length; m++)
                {
                    sum=sum+arr[m];
                    if (sum == s)
                    {
                        start = n;
                        end = m;
                        break;
                    }
                }
                sum = 0;
            }
            for (int n = start; n <= end; n++)
            {
                Console.Write("{0} ",arr[n]);
            }
            Console.WriteLine();

        }
    }

