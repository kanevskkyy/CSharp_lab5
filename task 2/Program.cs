using System;
using task_2;

class Task
{
    static void Main()
    {
        Console.WriteLine("Now, enter information about buyers like {Name} {Money}");
        Console.WriteLine("Then, enter information about products like {Name} {Price}");
        Console.WriteLine("After that enter what every buyers bought like {Name of person} {What bought}");
        line();
        Console.Write("Enter information of buyers = ");
        List<Persons> persons = new List<Persons>();
        string[] information_of_persons = Console.ReadLine().Split();
        
        for(int i = 0; i < information_of_persons.Length - 1; i += 2)
        {
            Persons temp_person  = new Persons();
            temp_person.Name = information_of_persons[i];
            if (information_of_persons[i] == "")
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            else if (int.Parse(information_of_persons[i+1]) < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            temp_person.Money = int.Parse(information_of_persons[i + 1]);
            persons.Add(temp_person);
        }

        Console.Write("Enter information of products = ");
        string[] information_of_products = Console.ReadLine().Split();
        List<Products> products = new List<Products>();
        for (int i = 0; i < information_of_products.Length - 1; i += 2)
        {
            Products temp_product = new Products();
            temp_product.Name = information_of_products[i];
            if (information_of_products[i] == "")
            {
                Console.WriteLine("Name cannot be empty");
                Environment.Exit(0);
            }
            else if (int.Parse(information_of_products[i + 1]) < 0)
            {
                Console.WriteLine("Money cannot be negative");
                Environment.Exit(0);
            }
            temp_product.Price = int.Parse(information_of_products[i + 1]);
            products.Add(temp_product);
        }

        Console.WriteLine("So now, enter what every buyers bought like {Name of person} {What bought}. If you want to end enter END/end");

        List<string> result = new List<string>();
        while (true)
        {
            Console.Write("Enter = ");
            string[] entered_information = Console.ReadLine().Split();
            if (entered_information.Length == 1 && entered_information[0].ToLower() == "end") break;

            string name_of_person = entered_information[0];
            string name_of_product = entered_information[1];
                        
            bool find_prouct = false;
            int price_of_product = 0; 
            for (int i = 0; i < products.Count; i++) 
            {
                if(name_of_product ==  products[i].Name)
                {
                    find_prouct = true;
                    price_of_product = products[i].Price;
                }
            }

            if(find_prouct)
            {
                for(int i = 0; i < persons.Count; i++)
                {
                    if (name_of_person == persons[i].Name)
                    {
                        if(persons[i].Money - price_of_product >= 0)
                        {
                            persons[i].Money -= price_of_product;
                            result.Add($"{persons[i].Name} bought {name_of_product}");
                        }
                        else
                        {
                            result.Add($"{persons[i].Name} can`t afford {name_of_product} ");
                        }
                    }
                }
            }
        }

        Console.WriteLine();
        for (int i = 0; i < result.Count; i++) 
        {
            Console.WriteLine(result[i]);

            string[] temp_string = result[i].Split();
            string temp_product;
            if (temp_string.Length == 3)
            {
                temp_product = temp_string[2];
                for (int j = 0; j < persons.Count; j++)
                {
                    if (persons[j].Name == temp_string[0]) persons[j].Package.Add(temp_product);
                }
            }
        }
        line();
        Console.WriteLine("RESULTS : ");
        for (int i = 0; i < persons.Count; i++) 
        {
            Console.Write(persons[i].Name + " - ");
            if (persons[i].Package.Count == 0) Console.Write(" Nothing bought");
            else
            {
                for (int j = 0; j < persons[i].Package.Count; j++)
                {
                    Console.Write(persons[i].Package[j] + " ");
                }
            }
            Console.WriteLine();
        }

    }
    public static void line()
    {
        Console.WriteLine("=======================================");
    }
}
