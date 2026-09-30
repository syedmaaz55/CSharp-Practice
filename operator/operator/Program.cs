using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = 4;
            int value2 = 5;

            Console.WriteLine("your addition answer is :" + (value1 + value2));
            Console.WriteLine("your subtraction answer is :" + (value1 - value2));
            Console.WriteLine("your multiplication answer is :" + (value1 * value2));
            Console.WriteLine("your divide answer is :" + (value1 / value2));
            Console.WriteLine("your modulous answer is :" + (value1 % value2));


            Console.WriteLine("The value of value1 is {0}", value1++);
            Console.WriteLine("The value of value1 is {0}", value1);

            Console.WriteLine("The value of value1 is {0}", ++value1);
            Console.WriteLine("---------------------------");
            Console.WriteLine("The value of value1 is {0}", value1--);
            Console.WriteLine("The value of value1 is {0}", value1);

            Console.WriteLine("The value of value1 is {0}", --value1);



            Console.ReadKey();
        }
    }
}
