using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class animal
    {
        public string name;
        public string sound;

    }
    class mammals : animal { 
    
    }
    class dog : mammals
    { 
    
        public void get()
        {
            Console.WriteLine("my name is {0} and my sound is {1}",this.name,this.sound);
        }
    }

    class cat : mammals
    {

        public void gets()
        {
            Console.WriteLine("my name is {0} and my sound is {1}", this.name, this.sound);
        }
    }
}
