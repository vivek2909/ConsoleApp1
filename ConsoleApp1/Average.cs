using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Average
    {
        public static void Main(string[] args)
        {
            double number1, number2, number3, number4;
            Console.WriteLine("Enter the First Number = ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Second Number = ");
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Third Number = ");
            number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Fourth Number = ");
            number4 = Convert.ToDouble(Console.ReadLine());
            double result = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine($"The Average of {number1},{number2},{number3},{number4} is = "+result);
        }
    }
}
