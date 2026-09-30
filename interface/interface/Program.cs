using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            human h = new human();
            h.bhao();
            h.meow();

            Console.ReadLine();
        }
    }

    interface IDog
    {
        void bhao();
    }

    interface ICat
    {
       void meow();
    }

    class human : ICat, IDog
    {
        public void bhao()
        {
            Console.WriteLine("DOGIIIIIIIIII");
        }

        public void meow()
        {
            Console.WriteLine("CATOOOOOOO");
        }
    }
}
