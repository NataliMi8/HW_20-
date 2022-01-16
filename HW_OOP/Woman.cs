using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP
{
    abstract class Woman : Human
    {
        abstract public string Name();
        abstract public double Age();
        abstract public string Pregnancy();
        abstract public string DyeHair();

        public override double WalkingAtSpeed()
        {
            return 5;
        }
        public override string Speak()
        {
            return "Hi";
        }                       
    }
}
