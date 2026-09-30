using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student std1 = new student();
            std1.id = 1;
            std1.name = "Pollard";
            std1.details();

            student std2 = new student();
            std2.id = 1;
            std2.name = "maaz";
            std2.details();
        
        vehicle v1 = new vehicle();
            v1.get("BYD", "mehran");
            v1.detail();

            vehicle v2 = new vehicle();
            v2.get("Toyota", "Varis");
            v2.detail();
        }

    }
    class student
    {

        public int id;
        public string name;

        public void details()
        {
            Console.WriteLine("student id is {0},student name is {1}",this.id,this.name);
        }
    }
    class vehicle
    {
        public string company;
        public string model;

        public void get(string companyname,string modelname)
        {
            this.company = companyname;
            this.model = modelname;
            }
        public void detail()
        {
            Console.WriteLine("{0} is the best company and model is {1}", this.company, this.model);
        }
    }
}
