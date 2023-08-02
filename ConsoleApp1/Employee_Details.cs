using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee_Details
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter Employee ID");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            int Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Employee Departmment");
            string Department = Console.ReadLine();

            Console.WriteLine("Entered Employee Details are as follows: ");
            Console.WriteLine($"Employee ID is = {EmployeeID}");
            Console.WriteLine($"Employee Name is = {name}");
            Console.WriteLine($"Employee Salary is = {Salary}");
            Console.WriteLine($"Employee Address is = {address}");
            Console.WriteLine($"Employee Department is = {Department}");
        }
    }
}
