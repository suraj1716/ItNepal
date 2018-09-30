using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItNepal.ConsoleApp.Math
{
    class Human
    {
        public int numberOfEyes;
        public Human()
        {
            numberOfEyes = 2;
        }

        public Human(int numberOfEyes)
        {
            this.numberOfEyes = numberOfEyes;

        }


        public void EyeOps(string Ops)

        {

            Console.WriteLine("{1}eye is {0}", Ops,this.numberOfEyes);
        }
    }
}
