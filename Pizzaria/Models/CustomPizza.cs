using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    class CustomPizza : Pizza
    {
        private double price;
        private Crust crust;
        private List<Topping> toppings = new List<Topping>();
        public CustomPizza(Crust crust, List<Topping> toppings)
        {
            Crust = crust;
            Toppings = toppings;
        }

        public double Price
        {
            get => price = toppings.Sum(x => x.Price) + crust.Price;
        }
        public Crust Crust
        {
            get => crust;
            set => crust = value;
        }
        public List<Topping> Toppings
        {
            get => toppings;
            set => toppings = value;
        }
    }
}
