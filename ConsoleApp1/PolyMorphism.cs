using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The Animal Makes a Sound");
        }
    }
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog Says : Bow Bow");
        }
    }
    public class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Cat Says : Meow Meow");
        }
    }
    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Pig Says : wee wee");
        }
    }
    public class Tiger : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Tiger Says : Roar");
        }
    }
        public class PolyMorphism
    {
        public static void Main()
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();
            Animal myPig = new Pig();
            Animal myTiger = new Tiger();

            myAnimal.AnimalSound();
            myDog.AnimalSound();
            myCat.AnimalSound();    
            myPig.AnimalSound();
            myTiger.AnimalSound();
        }
    }
}
