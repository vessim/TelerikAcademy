//Veldig bra! Det er en veldig godt oppgave!
﻿using System;

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

    class Array20Int
    {
        static void Main()
        {
            int[] arr = new int[25];
            for (int n = 0; n < 25; n++)
            {
                arr[n] = n * 5;
                Console.WriteLine(arr[n]);
            }

        }
    }

