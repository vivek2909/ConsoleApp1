using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array
    {
        static void Main(string[] args)
        {
            int[] arr = { 88, 2, 55, 23, 98, 4, 1, 57 };
            int n = arr.Length;

            int firstMax = int.MinValue;
            int secondMax = int.MinValue;

            for (int i = 0; i < n; i++) 
            {
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if (arr[i] > secondMax && arr[i] != firstMax)
                {
                    secondMax = arr[i];
                }
            }
            if (secondMax == int.MinValue)
            {
                Console.WriteLine("No Second Largest Element");
            }
            else
            {
                Console.WriteLine("Second Largest Element is : " + secondMax);
            }
        }
    }
}
