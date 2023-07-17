using System;
using System.Collections;

namespace Stack_Program
{
    class Program
    {
        static void Main()
        {
            Stack myStack = new Stack();

            myStack.Push("1st Element");
            myStack.Push("2nd Element");
            myStack.Push("3rd Element");
            myStack.Push("4th Element");
            myStack.Push("5th Element ");
            // myStack.Pop("4th Element");


            Console.Write("Total Numbers of elements in the stacks are : ");
            Console.WriteLine(myStack.Count);

            Console.Write("Element at top is : " + myStack.Peek());

            Console.WriteLine("element :", myStack.Pop());
            Console.Write("after at top is : " + myStack.Peek());

            Console.WriteLine(myStack.Count);
            Console.ReadLine();

        }
    }
}
