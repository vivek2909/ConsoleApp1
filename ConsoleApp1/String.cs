using System;
using System.Text;

namespace String_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            string name = "Hello";
            string name1 = " ";
            string name2 = "Buddy";
            string result = name + name1 + name2;
            Console.WriteLine(result + name1 + "My Name is Vivek I'm " + age + name1 + "years old.");
        }
    }
}
