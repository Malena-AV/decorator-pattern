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
            description = "Итальянское «espresso»";
        }

        public override double Cost()
        {
            return 200 + sum;
        }

    }
}
