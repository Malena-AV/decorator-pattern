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
        int milk;
        int soy;
        int mocha;
        int whip;

        double pricemilk = 14.1;
        double pricesoy = 27.1;
        double pricemocha = 16.9;
        double pricewhip = 35.1;

        public virtual double Cost()
        {
            return milk * pricemilk + soy * pricesoy + mocha * pricemocha + whip * pricewhip;
        }
        public string Description()
        {
            if (milk > 0)
            {
                description +=  "milk = " + milk + "\n";
            }
            if (soy > 0)
            {
                description += "soy = " + soy + "\n";
            }
            if (mocha > 0)
            {
                description += "mocha = " + mocha + "\n";
            }
            if (whip > 0)
            {
                description += "whip = " + whip + "\n";
            }
            return description;
        }
        public void Milk(int n)
        {
            milk= milk + n;
        }
        public void Soy(int n)
        {
            soy= soy + n;
        }
        public void Mocha(int n)
        {
            mocha= mocha + n;
        }
        public void Whip(int n)
        {
           whip= whip + n;
        }

    }   
}
