using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class BreadDecorator:Meal
    {
        Meal meal;
        public BreadDecorator(Meal meal)
        {
            this.meal = meal;
        }
        override public string GetDescription()
        {
            return this.meal.GetDescription() + " with bread";
        }
        override  public int GetCost()
        {
            return this.meal.GetCost() + 10;
        }
    }
}
