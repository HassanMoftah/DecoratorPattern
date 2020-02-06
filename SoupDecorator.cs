using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class SoupDecorator : Meal
    {
        Meal meal;
        public SoupDecorator(Meal meal)
        {
           this.meal = meal;
        }
        override public string GetDescription()
        {

            return this.meal.GetDescription() + " with soup";
        }
        override public int GetCost()
        {
            return this.meal.GetCost() + 15;
        }
    }
}
