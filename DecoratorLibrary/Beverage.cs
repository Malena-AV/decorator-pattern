using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorLibrary
{
    public class Beverage
    {

        public string description;
        double milk = 14.1;
        double soy = 27.1;
        double mocha = 16.9;
        double whip = 35.1;

        public virtual double Cost()
        {
            return milk + soy + mocha + whip;
        }
        public string Description()
        {
            return description;
        }
        public double Milk(int n)
        {
            description += "milk: " + milk*n + "\n";
            return milk*n;
        }
        public double Soy(int n)
        {
            description += "soy: " + soy*n + "\n";
            return soy*n;
        }
        public double Mocha(int n)
        {
            description += "mocha: " + mocha*n + "\n";
            return mocha*n;
        }
        public double Whip(int n)
        {
            description += "whip: " + whip*n + "\n";
            return whip*n;
        }

    }   
}
