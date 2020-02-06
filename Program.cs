using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        { 
            // order a  meat meal
            Meal meatMeal = new MeatMeal();

            //Console.WriteLine(meatMeal.GetDescription());
            // add bread with the meat meal
            meatMeal = new BreadDecorator(meatMeal);
            //add soup with meat meal 
            meatMeal = new SoupDecorator(meatMeal);

            Console.WriteLine(meatMeal.GetDescription());
            Console.WriteLine(":costs=" + meatMeal.GetCost());

            Meal chickenMeal = new ChickenMeal();

            //Console.WriteLine(meatMeal.GetDescription());
            // add bread with the meat meal
            chickenMeal = new BreadDecorator(chickenMeal);
            //add soup with meat meal 
            chickenMeal = new SoupDecorator(chickenMeal);

            Console.WriteLine(chickenMeal.GetDescription());
            Console.WriteLine(":costs=" + chickenMeal.GetCost());



        }
    }
}
