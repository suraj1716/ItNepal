using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItNepal.ConsoleApp.Math;

namespace ItNepal.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine("this human has {0}", human.numberOfEyes);
             
           
            
               Human secHuman = new Human(1);
            Console.WriteLine("{0} this human has {1}",secHuman.numberOfEyes);
            Console.ReadKey();


        }
    }
}
