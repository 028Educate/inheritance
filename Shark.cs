using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    //Shark inherits from Fish
    public class Shark : Fish
    {
        public string Name;
        public int NumOfTeeth;

        public void Eat()
        {
            Console.WriteLine("I love eating fish, seals, and anything meaty!");
        }
    }
}
