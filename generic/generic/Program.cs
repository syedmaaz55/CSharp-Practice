using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GENERIC CLASS-------------------------------");

            student<string> std = new student<string>();
            std.name= "Maazi";
            std.show();
            student<int> std1 = new student<int>();
            std1.name = 18;
            std1.show();

            Console.WriteLine("ARRAY LIST-------------------------------");

            List <string> lst = new List<string>();
            lst.Add("maazi");
            lst.Add("syed");
            lst.Add("45");
            foreach (string item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("DICTIONARY LIST-------------------------------");

            Dictionary<int,string> d1 = new Dictionary<int,string>();
            d1.Add(1, "syed");
            d1.Add(2, "maaz");
            d1.Add(3, "zain");

            foreach (KeyValuePair<int, string> item in d1)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }

            Console.WriteLine("QUEUE-------------------------------");

            Queue<string> q = new Queue<string>();
            q.Enqueue("Maaz");
            q.Enqueue("Syed");
            q.Enqueue("Hadi");

            while (q.Count > 0)
            {
                Console.WriteLine("Processing: " + q.Dequeue());
            }

            Console.WriteLine("STACK-------------------------------");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while (stack.Count > 0)
            {
                Console.WriteLine("Back To: " + stack.Pop());
            }

            Console.WriteLine("HASHSET-------------------------------");

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(1);
            set.Add(2);

            foreach (var et in set)
            {
                Console.WriteLine(et);
            }
        }
    }
    class student<T>
    {
        public T name;
        public void show()
        {
            Console.WriteLine("Student Name is :" + name);
        }
    }
}

