using System;
using System.Text;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("Buddy");
            string output = sb.ToString();
            Console.WriteLine(output + " My Name is Vivek I'm " + age + " years old.");
        }
    }
}
