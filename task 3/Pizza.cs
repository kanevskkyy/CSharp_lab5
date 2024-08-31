using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Pizza
    {
        public string Name { get; set; }
        public Dough dough { get; set; }
        private List<Topping> toppings = new List<Topping>();

        public Pizza(string name, Dough dough)
        {
            Name = name;
            this.dough = dough;
        }

        public void Add_topping(Topping topping)
        {
            toppings.Add(topping);
        }

        public double Calculate_calories()
        {
            double start_calories = dough.Calculate_dough_calories();
            for (int i = 0; i < toppings.Count; i++) 
            {
                start_calories += toppings[i].Calculate_topping_calories();
            }
            return start_calories;
        }

    }
}
