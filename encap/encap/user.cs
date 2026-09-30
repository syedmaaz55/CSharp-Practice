using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encap
{
    internal class user
    {
        private string _name;
        private int _age;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int age
        {
            get { return _age; }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Please Write Age");
                }
            }
        }
    }
}
