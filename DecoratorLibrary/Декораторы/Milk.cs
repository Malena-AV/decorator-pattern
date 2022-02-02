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
        Beverage beverage;
        public Milk (Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override double Cost()
        {
            return 4.1 + beverage.Cost();
        }
        public override string GetDescription()
        {
           return this.beverage.GetDescription() + "\nMilk";
        }
    }
}
