using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Espresso: Beverage
    {
        double expresso = 200;
        public override double Cost()
        {
            return expresso + sum;
        }
    }
}
