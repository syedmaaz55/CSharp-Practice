using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace non_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------ARRAY LIST----------------------");
            ArrayList lst = new ArrayList();
            lst.Add(1);
            lst.Add("maazi");
            lst.Add(134.944545);
            lst.Add(true);

            foreach (object item in lst)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------Hashtable----------------------");

            Hashtable ht = new Hashtable();
            ht["Name"] = "Syed Maaz";
            ht["Age"] = 34;

            Console.WriteLine("Name :" + ht["Name"]);
            Console.WriteLine("Age :" + ht["Age"]);

            Console.WriteLine("----------------------Queue----------------------");

            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue("maazi");

            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }

            Console.WriteLine("----------------------Stack----------------------");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        }
    }
}
