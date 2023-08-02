using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student_Details
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Details");
            Console.WriteLine("Enter Registration Number");
            int RegNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Marks of Three Subjects");
            Console.WriteLine("Subject 1");
            int Subject1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject 2");
            int Subject2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject 3");
            int Subject3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student Details are as follows:");
            Console.WriteLine($"Registration Number : {RegNumber}");
            Console.WriteLine($"Name : {name}");
            int n1 = Subject1 + Subject2 + Subject3;
            int n2 = n1 / 2;
            Console.WriteLine($"Total Marks : {n1}");
            Console.WriteLine($"Average Marks : {n2}");
        }
    }
}
