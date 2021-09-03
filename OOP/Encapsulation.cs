using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // using short hand property
        public int Age
        {
            get;
            set;
        }
        public void Print()
        {
            Console.WriteLine("Name = " + name + ", Age = " + Age);
        }
    }

    class Encapsulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation Example");
            Person person = new Person();
            person.Name = "Mohibur Rahman";
            person.Age = 24;
            person.Print();

            Console.ReadLine();
        }
    }
}
