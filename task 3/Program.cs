using System;
using System.Data;
using task_3;
using static Task;

class Task
{
    public enum Flours
    {
        White,
        Wholegrain,
    }

    public enum Bakings
    {
        Crispy,
        Chewy,
        Homemade
    }

    public enum Toppings
    {
        Meat,
        Veggies,
        Cheese,
        Sauce
    }

    static void Main()
    {
        Console.Write("Create Pizza : {Pizza} {Name of pizza} = ");
        string[] information_of_pizza = Console.ReadLine().Split();
        line();
        Dough dough = new Dough();
        Console.Write("Information of dough: Dough {Flour} {Baking method} {Weight} = ");
        string[] information_of_dought = Console.ReadLine().Split();
        line();
        
        if (!Enum.IsDefined(typeof(Flours), information_of_dought[1]) || !Enum.IsDefined(typeof(Bakings), information_of_dought[2]))
        {
            Console.WriteLine("Incorrect type of dough or baking method");
            Environment.Exit(0);
        }

        if (double.Parse(information_of_dought[3]) < 1.0 || double.Parse(information_of_dought[3]) > 200.0)
        {
            Console.WriteLine("Dough weight should be in range of [1 ... 200]");
            Environment.Exit(0);
        }
        dough.Flour = information_of_dought[1];
        dough.Baking = information_of_dought[2];
        dough.Weight = double.Parse(information_of_dought[3]);

        Console.WriteLine("Now let`s add topping on pizza, enter END to finish :");
        Pizza pizza = new Pizza(information_of_pizza[1], dough);

        while(true)
        {
            Topping topping = new Topping();
            Console.Write("Information of topping: Topping {Topping} {Weight} = ");
            string[] information_of_topping = Console.ReadLine().Split();
            if (information_of_topping.Length == 1 && information_of_topping[0].ToLower() == "end") break;
            if (!Enum.IsDefined(typeof(Toppings), information_of_topping[1]))
            {
                Console.WriteLine($"Cannot place {information_of_topping[1]} on the top of pizza");
                Environment.Exit(0);
            }
            double weight = double.Parse(information_of_topping[2]);
            if (weight < 1 || weight > 50)
            {
                Console.WriteLine($"{information_of_topping[1]} weight should be in range [1...50]");
                Environment.Exit(0);
            }
            topping.Stuffing = information_of_topping[1];
            topping.Weight = double.Parse(information_of_topping[2]);
            pizza.Add_topping(topping);
            line();
        }
        Console.WriteLine($"\n{pizza.Name} - {pizza.Calculate_calories()} Calories.");

    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
