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
            Console.WriteLine("Стоимость: " + decar.Cost());
            Console.WriteLine("Стоимость: " + espresso.Cost());
            Console.WriteLine("Стоимость: " + darkroast.Cost());
            Console.WriteLine("Стоимость: " + houseblend.Cost());
            Console.ReadKey();


        }
        
    }
}
