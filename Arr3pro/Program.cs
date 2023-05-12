using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr3pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i, n, sum = 0;

            // "Write a program in C# Sharp to find the sum of all array elements.  //Question
            

            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());        //input 

            Console.WriteLine("Input {0} elements in the array : ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum = sum + a[i];
            }

            Console.WriteLine("Sum of all elements stored in the array is : {0} ", sum);
            Console.ReadLine();

        }
    }
}
