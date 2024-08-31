using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Topping
    {
        public string Stuffing {  get; set; }
        public double Weight { get; set; }

        public double Calculate_topping_calories()
        {
            double start_calories = 2.0;
            string[] stuffing_choice = { "Meat", "Veggies", "Cheese", "Sauce" };
            double[] ratio_for_stuffing = { 1.2, 0.8, 1.1, 0.9 };

            double ratio = 1.0;
            for (int i = 0; i < stuffing_choice.Length; i++) 
            {
                if(Stuffing ==  stuffing_choice[i]) ratio = ratio_for_stuffing[i];
            }

            return start_calories * ratio * Weight;
        }
    }
}
