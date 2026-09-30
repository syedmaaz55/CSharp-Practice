using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            user u1 = new user();
            u1.name = "MAAZI";
            u1.age = 34;
            Console.WriteLine(u1.name);
            Console.WriteLine(u1.age);
        }
    }
}
