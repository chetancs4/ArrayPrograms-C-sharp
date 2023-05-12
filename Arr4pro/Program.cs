using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr4pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;

            // "Write a C# Sharp program to copy the elements of one array into another array."        //Quesion

            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input {0} elements in the array: ", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            /* Prints the elements of first array   */
            Console.WriteLine("\nThe elements stored in the first array are : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* Prints the elements copied into the second array. */
            Console.WriteLine("\nThe elements copied into the second array are : ");
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}  ", arr2[j]);
            }
            Console.ReadLine();
       
        }
    }
}
