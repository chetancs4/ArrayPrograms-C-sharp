using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arr18pro
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 5, 4, 2, 3, 4 };
            int[] result = test(nums);

            //Write a C# Sharp program to get only odd values from a given integer array

            Console.WriteLine("Only the odd values of the said array: ");
            Array.ForEach(result, Console.WriteLine);
            int[] nums1 = { 2, 4, 2, 6, 4, 8 };
            result = test(nums1);
            Console.WriteLine("Only the odd values of the said array: ");
            Array.ForEach(result, Console.WriteLine);
            Console.ReadLine();
        }
        public static int[] test(int[] arr)
        {
            return arr.Where(n => n % 2 != 0).ToArray();
            Console.ReadLine();
        }
    
    }
}
