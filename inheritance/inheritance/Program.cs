using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car();
            c1.name = "Corolloa";
            c1.model = 2023;
            c1.speed = 4000;
            c1.details();

            bike b1 = new bike();
            b1.name = "Toyota";
            b1.model = 2017;
            b1.petrol = 8;
            b1.details();
            Console.WriteLine("---------------------------------");
            
            dog d = new dog();
            d.name = "puppy";
            d.sound = "Bhaoo";
            d.get();

            dog c = new dog();
            c.name = "kiki";
            c.sound = "Meow Meow";
            c.get();


            cat ca = new cat();
            ca.name = "mano";
            ca.sound = "wow wow";
            ca.gets();
        }
    }

    class vehicle
    {
        public string name;
        public int model;
    }
    class car : vehicle
    {
        public int speed;

        public void details()
        {
            Console.WriteLine("{0} is the best car and its model is {1} and speed is {2}",this.name,this.model,this.speed);
        }
    }

    class bike : vehicle
    {
        public int petrol;

        public void details()
        {
            Console.WriteLine("{0} is the best car and its model is {1} and petrol is {2}", this.name, this.model, this.petrol);
        }
    }
}
