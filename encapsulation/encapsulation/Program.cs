using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student();
            std1.name = "POlLARD";
            std1.age = -1;

            Console.WriteLine(std1.name);
            Console.WriteLine(std1.age);

        }
    }
}
