using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    internal class Chicken
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Chicken() { }

        public double product_per_day
        {
            get 
            {
                return calculate_amount_of_eggs(); 
            }
        }
        private double calculate_amount_of_eggs()
        {
            if (Age < 4) return 0.5;
            else if (Age >= 4 && Age <= 10) return 1;
            else return 1.5;
        }

    }
}
