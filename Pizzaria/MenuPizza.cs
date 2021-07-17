using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class MenuPizza : Pizza
    {
        private string name;
        private double price;
        private Crust crust;
        private List<Topping> toppings = new List<Topping>();
        public MenuPizza(string name, double price, Crust crust, List<Topping> toppings)
        {
            Name = name;
            Price = price;
            Crust = crust;
            Toppings = toppings;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }

        public double Price
        {
            get => price;
            set => price = value;
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
