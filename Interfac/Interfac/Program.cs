internal class Program
{
    private static void Main(string[] args)
    {
        human h = new human();
        h.bhao();
        h.meow();
    }
    interface IDog { 
        void bhao(); 
    }
    interface ICat {
        void meow(); 
    }
    class human : ICat, IDog { 
        public void bhao() { 
            Console.WriteLine("DOGIIIIIIIIII");
        } 
        public void meow() { Console.WriteLine("CATOOOOOOO");
        } 
    }
}
