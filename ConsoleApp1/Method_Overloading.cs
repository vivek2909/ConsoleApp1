using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Method_Overloading
    {
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }
        static double PlusMethod(double x, double y) 
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int myNum1 = PlusMethod(4, 6);
            double myNum2 = PlusMethod(2.56, 7.34);
            Console.WriteLine("Int : " +myNum1);
            Console.WriteLine("Double : " + myNum2);
        }
    }
}
