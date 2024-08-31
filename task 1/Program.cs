using System;
using task_1;

class Task
{
    static void Main()
    {
        Chicken chicken = new Chicken();
        string name;
        int age;
        Console.Write("Enter name of chicken = ");
        name = Console.ReadLine();
        line();
        while (name == null || name == "" || name.Contains(" "))
        {
            Console.Write("Error... Name cannot be null, zero of contains spaces");
            Console.Write("Enter name of chicken = ");
            name = Console.ReadLine();
            line();
        }

        Console.Write("Enter age of chicken = ");
        age = int.Parse(Console.ReadLine());
        line();
        while (age < 0 || age > 15)
        {
            Console.WriteLine("Error... Age of chicken should be betweeen 0 and 15");
            Console.Write("Enter age of chicken = ");
            age = int.Parse(Console.ReadLine());
            line();
        }
        chicken.Age = age;
        chicken.Name = name;

        Console.WriteLine($"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.product_per_day} eggs per day");
    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
