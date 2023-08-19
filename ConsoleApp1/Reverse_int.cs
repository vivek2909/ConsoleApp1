using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Reverse_int
    {
        static void Main(string[] args)
        {
            int num = 56789;
            int reversed = ReverseInteger(num);
            Console.WriteLine("Reversed Integer :" + reversed);
        }
        static int ReverseInteger(int num)
        {
            int reversed = 0; 
            while (num != 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }
            return reversed;
        }
    }
}
