using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    abstract class Masha : Woman
    {
        public override string Name()
        {
            return "Masha";
        }
        public override double Age()
        {
            return 45;
        }
        public override string Pregnancy()
        {
            return "5 children";
        }
        public override string DyeHair()
        {
            return "blond";
        }
        public override string ToString()
        {
            return $"Name: {Name()} \nAge: {Age()} \nHad {Pregnancy()} \nShe dyed her hair  {DyeHair()}";
        }

    }
}
