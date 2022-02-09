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

            decar.Mocha(1);
            Console.WriteLine(decar.Description() + "стоимость: " + decar.Cost() + "\n");

            espresso.Whip(2);
            espresso.Milk(5);

            espresso.Milk(4);

            Console.WriteLine(espresso.Description() + "стоимость: " + espresso.Cost() + "\n");
           
            darkroast.Soy(2);
            Console.WriteLine(darkroast.Description() + "стоимость: " + darkroast.Cost() + "\n");
           
            Console.WriteLine(houseblend.Description() +  "стоимость: " + houseblend.Cost() + "\n");
            Console.ReadKey();


        }
        
    }
}
