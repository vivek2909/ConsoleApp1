using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Multiplication
    {
        public static void Main()
        {
            int number1,number2,number3,temp;
            Console.WriteLine("Enter First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number : ");
            number3 = int.Parse(Console.ReadLine());
            temp = (number1 * number2 * number3);
            Console.WriteLine($"{number1}*,{number2}*,{number3} = " + temp);
        }
    }
}
