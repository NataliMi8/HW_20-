using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    abstract class Petya : Men
    {
        public override string Name()
        {
            return "Petya";
        }
        public override double Age()
        {
            return 62;
        }
        public override double Fertilize()
        {
            return 3;
        }
        public override string CantDistinguishColors()
        {
            return "red";
        }
        public override string LiftTheChairInBentPosition()
        {
            return "сouldn't pull up a chair";
        }
        public override string ToString()
        {
            return $"Name: {Name()} \nAge: {Age()} \nHe gave birth to {Fertilize()} children \nHe's color blind, he can't tell the color  {CantDistinguishColors()}  \nHe {LiftTheChairInBentPosition()}";
        }
    }
}
