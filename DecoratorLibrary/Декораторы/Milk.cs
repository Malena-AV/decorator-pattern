using DecoratorLibrary.Классы_наследники;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Milk: CondimentDecorator
    {
        readonly Beverage beverage;
        readonly double cost = 4.1;
        public Milk (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return cost + beverage.Cost();
        }
        public override string GetDescription()
        {
           return beverage.GetDescription() + "\nMilk " + cost;
        }
    }
}
