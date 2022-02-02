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
            milk *=  n;
            description += "milk: " + milk + "\n";
            return milk;
        }
        public double Soy(int n)
        {
            soy *= n;
            description += "soy: " + soy + "\n";
            return soy;
        }
        public double Mocha(int n)
        {
            mocha *= n;
            description += "mocha: " + mocha + "\n";
            return mocha;
        }
        public double Whip(int n)
        {
            whip *= n;
            description += "whip: " + whip + "\n";
            return whip;
        }

    }   
}
