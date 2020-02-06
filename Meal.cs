using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
     abstract class Meal
    {
        public string Description;
        virtual public string GetDescription()
        {
            return this.Description;
        }
        public abstract int GetCost();
    }
}
