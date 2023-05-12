using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr2pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int[] a = new int[100];

            // Write a C# Sharp program to read n values in an array and display them in reverse order."

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine()); //user input

            Console.WriteLine("Input {0} number of elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The values store into the array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            //reverse order
            Console.WriteLine("\nReverse Array are : ");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.ReadLine();
        }
    }
}
