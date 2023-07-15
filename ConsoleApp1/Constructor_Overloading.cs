using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading
{
    public class Car
    {
        Car(string brand, int price)
        {
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Price : " + price);
        }
        Car(int speed, string color)
        {
            Console.WriteLine("Speed : " +  speed);
            Console.WriteLine("Color : " +  color);
        }
        static void Main(string[] args)
        {
            Car car = new Car("XUV 700", 2500000);
            Console.WriteLine();

            Car car2 = new Car(170, "Blue");
            Console.ReadLine();
        }
    }
}
