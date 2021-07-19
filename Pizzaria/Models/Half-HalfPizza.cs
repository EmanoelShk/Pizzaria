using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria
{
    class Half_HalfPizza
    {
        private double price;
        private Crust crust;
        private List<Topping> firstToppings = new List<Topping>();
        private List<Topping> secondToppings = new List<Topping>();
        public Half_HalfPizza(Crust crust, List<Topping> firstToppings, List<Topping> secondToppings)
        {
            Crust = crust;
            FirstToppings = firstToppings;
            SecondToppings = secondToppings;
        }

        public Half_HalfPizza(Crust crust,MenuPizza firstPizza, MenuPizza secondPizza)
        {
            Crust = crust;
            FirstToppings = firstPizza.Toppings;
            SecondToppings = secondPizza.Toppings;
        }

        public double Price
        {
            get => price = firstToppings.Sum(x => x.Price) + secondToppings.Sum(x => x.Price) + crust.Price;
        }
        public Crust Crust
        {
            get => crust;
            set => crust = value;
        }
        public List<Topping> FirstToppings
        {
            get => firstToppings;
            set => firstToppings = value;
        }

        public List<Topping> SecondToppings
        {
            get => secondToppings;
            set => secondToppings = value;
        }

    }
}
