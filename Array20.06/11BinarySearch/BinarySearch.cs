using System;
//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm
//(find it in Wikipedia).

    class BinarySearch
    {
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2,12, 7,5, 8 };
            //sort
            int min = arr[0];
            for (int n = 0; n < arr.Length; n++)
            {
                if (min > arr[n])
                {
                    min = arr[n];
                }
            }
            
           int max = min;
            int keepInd=0;
            for (int n = 0; n < arr.Length; n++)
            {
                for (int m = 0; m < arr.Length - n; m++)
                {
                    if (max < arr[m])
                    {
                        max=arr[m];
                        keepInd = m;
                    }
                }
                arr[keepInd] = arr[arr.Length - 1 - n];
                arr[arr.Length - 1 - n] = max;
                max = min;
            }
            //print
            for (int n = 0; n < arr.Length; n++)
            {
                Console.Write("{0} ", arr[n]);
            }
            Console.WriteLine();
            //search
            int five = 12;
            int start = 0;
            int end = arr.Length-1;
            int middle = (end - start) / 2;
            while (true)
            {
               
                if (five < arr[middle])
                {
                    end = middle;
                    middle = (end - start) / 2;
                }
                else if (five > arr[middle])
                {
                    start = middle;
                    middle = middle + ((end - start) / 2);
                    if (five == arr[end])
                    {
                        middle = end;
                    }
                }
                
                else
                {
                    Console.WriteLine(middle);
                    break;
                }
            }
        }
    }

