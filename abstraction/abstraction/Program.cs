using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction
{
    internal abstract class Program
    {

        public abstract void speed();
        public void gen()
        {
            Console.WriteLine("very fast");
        }

 
        static void Main(string[] args)
        {
            car p1 = new car();
            p1.speed();
            p1.gen();
        }
    }
    class car : Program
    {
        public override void speed()
        {
            Console.WriteLine("It Is Very Fast!");
        }
    }
}
