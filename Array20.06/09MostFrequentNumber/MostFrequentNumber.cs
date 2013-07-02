using System;
//Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

    class MostFrequentNumber
    {
        static void Main()
        {
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int tempCount = 0;
            int maxCount = 0;
            int num = 0;
            for (int n = 0; n < arr.Length; n++)
            {
                for (int m = 0; m < arr.Length; m++)
                {
                    if (arr[n] == arr[m])
                    {
                        tempCount++;
                        if (tempCount > maxCount)
                        {
                            maxCount = tempCount;
                            num = arr[n];
                        }
                    }
                }
                tempCount = 0;
            }
            Console.WriteLine("{0} ({1} times)",num,maxCount);
        }
    }

