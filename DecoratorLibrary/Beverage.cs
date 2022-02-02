using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    abstract public class Beverage
    {

        public string description;
        public abstract double Cost();

        public string Description
        {
            get
            {
                return description;
            }
        }
    }   
}
