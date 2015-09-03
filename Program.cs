using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Fish and a Shark Object
            Fish fish = new Fish();
            Shark cShark = new Shark();

            //Can access Fish members due to Inheritance 

            //Assignment of fish inherited NumOfGills variable
            cShark.NumOfGills = 10;
            //Fish method can be called on shark as it is inherited
            cShark.Breath();

            //Shark specific members
            //Assignment of Shark NumOfTeeth variable
            cShark.NumOfTeeth = 240;
            //Shark method
            cShark.Eat();
        }
    }
}
