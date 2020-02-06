using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    class MeatMeal:Meal
    {
        public MeatMeal()
        {
            this.Description = "well done meat meal";
        }
        override public int GetCost()
        {
            return 40;
        }
    }
}
