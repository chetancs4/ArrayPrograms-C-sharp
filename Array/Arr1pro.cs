using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Arr1pro
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            // "Write a C# Sharp program that stores elements in an array and prints them."            

            Console.WriteLine("Input 4 elements in the array : ");
            for (i = 0; i < 4; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
     
            Console.ReadLine();
        }
    }
}
