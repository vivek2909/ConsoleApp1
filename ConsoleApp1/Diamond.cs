using System;

namespace Diamond
{
    interface A
    {
        void Loan();
    }
    interface B
    {
        void Loan();
    }
    public class Mother : A
    {
        public void Loan()
        {
            Console.WriteLine("Loan taken by A.");
        }
    }
    public class Father : B
    {
        public void Loan()
        {
            Console.WriteLine("Loan taken by B");
        }
    }
    public class Child : A, B
    {
        void A.Loan()
        {
            Console.WriteLine("A loan paid by D");
        }

        void B.Loan()
        {
            Console.WriteLine("B loan paid by D");
        }
    }

    public class Diamond
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            ((A)child).Loan();
            ((B)child).Loan();

            Console.ReadLine();
        }
    }
}
