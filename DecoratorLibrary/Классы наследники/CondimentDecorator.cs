using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary.Классы_наследники
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract override string GetDescription(); 
    }
}
