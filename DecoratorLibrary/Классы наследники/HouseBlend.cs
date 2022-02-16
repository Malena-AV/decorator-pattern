using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public  class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            description = "Свежеобжаренный кофе";
        }
        public override double Cost()
        {
            return 150;
        }
    }
}
