using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            Description = "Тёмный кофе";
        }
        public override double Cost()
        {
            return 50;
        }

    }
}
