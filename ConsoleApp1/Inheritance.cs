using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class MyClass1
    {
        public void Method1()
        {
            Console.WriteLine("one");
        }
    }
    public class MyClass2 : MyClass1
    {
        public void Method1()
        {
            Console.WriteLine("Two");
        }
    }
    
public class Inheritance
{
    public static void Main(string[] args)

    {
        MyClass1 obj1 = new MyClass1();
        MyClass2 obj2 = new MyClass2();
         
        obj1.Method1();
        obj2.Method1();
        
    }
}
    
    

