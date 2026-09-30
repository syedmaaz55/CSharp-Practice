using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculater c1 = new Calculater();
            c1.get(12, 24);
            c1.get(55);
            c1.get(22, 2,100);

            Console.WriteLine("-------------------------");

            c1.set("zain");
            c1.set("Babar", "Kholi");

            Console.WriteLine("-------------------------");


            cat mycat = new cat();
            mycat.sound();
            dog d1 = new dog();
            d1.sound();
        }
    }
    class Calculater
    {
        public void get(int value1,int value2)
        {
            Console.WriteLine(value1 + value2);
        }
        public void get(int value1)
        {
            Console.WriteLine("Your Number is " + value1);
        }
        public void get(int value1, int value2,int value3)
        {
            Console.WriteLine(value1 + value2 + value3);
        }
        public void set(string name)
        {
            Console.WriteLine("Your Name is" + " " + name);
        }
        public void set(string name,string fathername)
        {
            Console.WriteLine("Your Name is" + " " + name + " " + "Your FatherName is" + " " + fathername);
        }
    }
}
