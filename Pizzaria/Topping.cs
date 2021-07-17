using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria
{
    class Topping
    {
        private string name;
        private double price;

        public Topping(string name, double price)
        {
            Name = name;
            Price = price;
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
            get
            {
                return this.price;
            }
            set
            {
                price = value;
            }
        }
    }
}
