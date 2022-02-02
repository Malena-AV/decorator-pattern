using DecoratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage decar = new Decaf();
            Console.WriteLine(decar.GetDescription() +  "\nстоимость: " + decar.Cost() + "\n");
            
            Beverage espresso = new Espresso();
            espresso = new Mocha(espresso);
            Console.WriteLine(espresso.GetDescription() + "\nстоимость: " + espresso.Cost() + "\n");

            Beverage darkroast = new DarkRoast();
            darkroast = new Milk(darkroast);
            darkroast = new Soy(darkroast);
            Console.WriteLine(darkroast.GetDescription() +  "\nстоимость: " + darkroast.Cost() + "\n");

            Beverage houseblend = new HouseBlend();
            houseblend = new Whip(houseblend);
            houseblend = new Whip(houseblend);
            Console.WriteLine(houseblend.GetDescription() + "\nстоимость: " + houseblend.Cost() + "\n");
            Console.ReadKey();


        }
        
    }
}
