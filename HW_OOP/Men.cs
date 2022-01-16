using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    abstract class Men : Human
    {
        abstract public string Name();
        abstract public double Age();       
        abstract public double Fertilize();
        abstract public string CantDistinguishColors();
        abstract public string LiftTheChairInBentPosition();
        public override double WalkingAtSpeed()
        {
            return 5;
        }
        public override string Speak()
        {
            return "Hello";
        }
    }
}
