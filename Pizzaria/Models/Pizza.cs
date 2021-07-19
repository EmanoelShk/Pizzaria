using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    interface Pizza
    {
        public double Price
        {
            get;
        }

        public Crust Crust
        {
            get;
        }

        public List<Topping> Toppings
        {
            get;
        }
    }
}
