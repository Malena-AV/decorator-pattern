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
        double milk;
        double soy;
        double mocha;
        double whip;

        double pricemilk = 14.1;
        double pricesoy = 27.1;
        double pricemocha = 16.9;
        double pricewhip = 35.1;

        public virtual double Cost()
        {
            return milk + soy + mocha + whip;
        }
        public string Description()
        {
            return description;
        }
        public void Milk(int n)
        {
            milk= pricemilk*n;
            description += "Milk = " + milk + "\n";
        }
        public void Soy(int n)
        {
            soy = pricesoy*n;
            description += "Soy = " + soy + "\n";
        }
        public void Mocha(int n)
        {
            mocha = pricemocha*n;
            description += "Mocha = " + mocha + "\n";
        }
        public void Whip(int n)
        {
           whip = pricewhip*n;
           description += "Whip = " + whip + "\n";

        }

    }   
}
