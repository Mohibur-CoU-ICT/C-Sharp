using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // static or compile time polymorphism
    class Calculate
    {
        public int Add(int a, int b)
        {
            return a+b;
        }
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    // dynamic or runtime polymorphism
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Cat : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The cat says: mew mew");
        }
    }

    class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Polymorphism
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static or Compile time Polymorphism Example");
            Calculate calculate = new Calculate();
            Console.WriteLine(calculate.Add(10, 20));
            Console.WriteLine(calculate.Add(10, 20, 30));
            Console.WriteLine(calculate.Add(10.5, 20.5));

            Console.WriteLine("Dynamic or Runtime Polymorphism Example");
            Cat cat = new Cat();
            cat.AnimalSound();
            Dog dog = new Dog();
            dog.AnimalSound();

            Console.ReadLine();
        }
    }
}
