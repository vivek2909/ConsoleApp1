using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {
            int number1, number2;
            Console.Write("First Number = ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Second Number = ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number1} + {number2} = "+(number1 + number2));
            Console.WriteLine($"{number1} - {number2} = "+(number1 - number2));
            Console.WriteLine($"{number1} * {number2} = "+(number1 * number2));
            Console.WriteLine($"{number1} / {number2} = "+(number1 / number2));
            Console.WriteLine($"{number1} Mod {number2} = "+(number1 % number2));
        }
    }
}
