﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr11pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            // Write a C# Sharp program to sort elements of an array in ascending order.

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
