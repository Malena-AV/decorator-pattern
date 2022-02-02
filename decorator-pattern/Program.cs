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

            Console.WriteLine(decar.Description + " "+ "стоимость: " + decar.Cost());
            
            Beverage espresso = new Espresso();
            espresso = new Mocha(espresso);
            
            Console.WriteLine(espresso.Description + " " + "стоимость: " + espresso.Cost());

            Beverage darkroast = new DarkRoast();
            darkroast = new Milk(darkroast);
            darkroast = new Soy(darkroast);
            Console.WriteLine(darkroast.Description + " " + "стоимость: " + darkroast.Cost());

            Beverage houseblend = new HouseBlend();
            houseblend = new Whip(houseblend);
            houseblend = new Whip(houseblend);
            Console.WriteLine(houseblend.Description + " " + "стоимость: " + houseblend.Cost());
            Console.ReadKey();


        }
        
    }
}
