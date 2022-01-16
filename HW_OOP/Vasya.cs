using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    abstract class Vasya : Men
    {
        public override string Name()
        {
            return "Vasya";
        }
        public override double Age()
        {
            return 38;
        }
        public override double Fertilize()
        {
            return 5;
        }
        public override string CantDistinguishColors()
        {
            return "green";
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
