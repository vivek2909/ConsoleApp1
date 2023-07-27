using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Swap
    {
        public static void Main()
        {
            int number1, number2, temp;
            Console.WriteLine("Enter First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After Swapping");
            Console.WriteLine("First Number : "+number1);
            Console.WriteLine("Second Number : "+number2);
        }
    }
}
