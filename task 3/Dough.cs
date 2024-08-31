using System;
using System.Collections.Generic;

namespace task_3
{
    internal class Dough
    {
        public string Flour { get; set; }
        public string Baking { get; set; }
        public double Weight { get; set; }
    
        public double Calculate_dough_calories()
        {
            double start_calories = 2.0;
            string[] type_of_baking = {"Crispy", "Chewy", "Homemade" };
            double[] ratio_for_flour = { 0.9, 1.1, 1.0 };

            double baking_cooficient = 0.0;
            for (int i = 0; i < type_of_baking.Length; i++) 
            {
                if (type_of_baking[i] == Baking) baking_cooficient = ratio_for_flour[i];
            }

            double flour_coofiicent = Flour.ToLower() == "white"? 1.5 : 1.0;
            return start_calories * baking_cooficient * flour_coofiicent * Weight;
        }
    }
}