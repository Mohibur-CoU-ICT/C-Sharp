using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // use sealed keyword to make a class not inheritable
    class Vehicle
    {
        public string brand = "Ford";
        public void Honk()
        {
            Console.WriteLine("Toot, toot!");
        }
    }

    class Car : Vehicle
    {
        public string modelName = "Mustang";
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Example");
            Car car = new Car();
            car.Honk();
            Console.WriteLine(car.brand + " " + car.modelName);

            Console.ReadLine();
        }
    }
}
