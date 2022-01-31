using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public  class HouseBlend: Beverage
    {
        double houseblend = 150;
        public override double Cost()
        {
            return houseblend + sum;
        }
    }
}
