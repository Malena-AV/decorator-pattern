using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class DarkRoast: Beverage
    {
        double darkroast = 50;
        public override double Cost()
        {
            return darkroast + sum;
        }
    }
}
