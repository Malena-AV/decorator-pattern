using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            Description = "Без кофеина";
        }
        public override double Cost()
        {
            return 100;
        }
    }
}
