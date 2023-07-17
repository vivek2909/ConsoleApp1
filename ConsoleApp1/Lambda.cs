using System;
using System.Collections.Generic;


public static class Lambda
{
    public static void Main()
    {
        List<int> list = new List<int>() { 31, 32, 33, 34, 35, 36 };
        List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

        foreach (var num in evenNumbers)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Read();
    }
}
