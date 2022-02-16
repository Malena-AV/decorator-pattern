using DecoratorLibrary.Классы_наследники;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Whip : CondimentDecorator
    {
        readonly Beverage beverage;
        readonly double cost = 3.9;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return cost + beverage.Cost();
        }
        public override string GetDescription()
        {
           return beverage.GetDescription() + "\nWhip " + cost;
        }
    }
}
