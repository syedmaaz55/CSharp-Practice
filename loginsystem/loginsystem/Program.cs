using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "maaz";
            int password = 55;

            Console.WriteLine("Login First");


            Console.Write("Your username is :");
            string uname = Console.ReadLine();

            Console.Write("Your password is :");
            int pass = int.Parse(Console.ReadLine());

            if (username == uname & password == pass)
            {
                Console.WriteLine("LOGIN SUCESSFULLY");
            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }

            Console.ReadKey();


        }
    }
}
