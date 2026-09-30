using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car v1 = new car();
            v1.speed();
            v1.gree();
        }
    }
    abstract class vehicle {
        public abstract void speed();

        public void gree()
        {
            Console.WriteLine("Fast GOOOOOOOOOO");
        }
    }
    class car : vehicle
    {
        public override void speed()
        {
            Console.WriteLine("RUNNING RUNNING");
        }
            }


}
