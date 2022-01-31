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
            Beverage espresso = new Espresso();
            Beverage darkroast = new DarkRoast();
            Beverage houseblend = new HouseBlend();

            decar.Mocha();
            espresso.Milk();
            espresso.Soy();
            darkroast.Whip();
            houseblend.Milk();
            Console.WriteLine(decar.Description + " "+ "стоимость: " + decar.Cost());
            Console.WriteLine(espresso.Description + " " + "стоимость: " + espresso.Cost());
            Console.WriteLine(darkroast.Description + " " + "стоимость: " + darkroast.Cost());
            Console.WriteLine(houseblend.Description + " " + "стоимость: " + houseblend.Cost());
            Console.ReadKey();


        }
        
    }
}
