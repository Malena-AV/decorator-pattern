using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    abstract public class Beverage
    {
        double description = 2.3;
        double milk = 4.1;
        double soy = 2.0;
        double mocha = 5.1;
        double whip = 3.9;
        public double sum = 0;

        abstract public double Cost();

        public double Description()
        {
            sum = sum + description;
            return description;
        }
        public double Milk()
        {
            sum = sum + milk;
            return sum;
        }
        public double Soy()
        {
            sum = sum + soy;
            return sum;
        }
        public double Mocha()
        {
            sum = sum + mocha;
            return sum;
        }
        public double Whip()
        {
            sum = sum + whip;
            return sum;
        }
    }   
}
