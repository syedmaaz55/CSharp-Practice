using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class animal
    {
        public virtual void sound()
        {
            Console.WriteLine("hhhhhhhhhhhhhh");
        }
    }
        class cat : animal
 {
        public override void sound()
            {
                Console.WriteLine("Meow");
            }
        }
        class dog : animal {
            public override void sound()
            {
                Console.WriteLine("Bhao");
            }
        }
    
}
