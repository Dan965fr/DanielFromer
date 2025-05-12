using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> inside = new HashSet<string>();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Enter");
            Console.WriteLine("2. Exit");
            Console.WriteLine("3. Show who is inside");
            Console.WriteLine("4. Exit program");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter name: ");
                    string nameIn = Console.ReadLine();
                    if (inside.Add(nameIn))
                        Console.WriteLine("welcome!");
                    else
                        Console.WriteLine("Already inside.");
                    break;

                case "2":
                    Console.Write("Enter name: ");
                    string nameOut = Console.ReadLine();
                    if (inside.Remove(nameOut))
                        Console.WriteLine("bye!");
                    else
                        Console.WriteLine("Error: this person is not inside.");
                    break;

                case "3":
                    Console.WriteLine("People currently inside:");
                    foreach (var person in inside)
                    {
                        Console.WriteLine("- " + person);
                    }
                    break;

                case "4":
                    Console.WriteLine("Shutting down system.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
