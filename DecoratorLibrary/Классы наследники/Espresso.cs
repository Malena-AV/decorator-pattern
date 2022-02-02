using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Espresso: Beverage
    {
        public Espresso()
        {
            description = "Итальянское «espresso»\n";
        }

        public override double Cost()
        {
            return base.Cost() + 150;
        }

    }
}
