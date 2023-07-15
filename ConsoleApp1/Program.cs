using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public string model;
        public Car()
        {
            model = "XUV 700";
        }
        static void Main(string[] args)
        {
            Car Mahindra = new Car();
            Console.WriteLine(Mahindra.model);
        }
    }
}
