using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tables
    {
        public static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter The Number : ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Table of the {number} is");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number * i);
            }
        }
    }
}
