using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class ChickenMeal:Meal
    {
       
        public ChickenMeal()
        {
          
            Description = "Well done Chicken meal";
        }
        override public int GetCost()
        {
            return 30;
        }
    }
}
