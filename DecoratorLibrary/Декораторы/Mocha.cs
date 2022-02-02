using DecoratorLibrary.Классы_наследники;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Mocha: CondimentDecorator
    {
        Beverage beverage;
        public Mocha (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 5.1 + beverage.Cost() ;
        }
        public override string GetDescription()
        {
            return this.beverage.GetDescription() + "\nMocha";
        }
    }
}
