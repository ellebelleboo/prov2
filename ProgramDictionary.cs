using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //implementing a dictionary
            Dictionary<string, string> items = new Dictionary<string, string>();
            bool running = true;


            while (running)
            {
                //Show the menu
                Console.WriteLine("a.Add an item and its definition");
                Console.WriteLine("b.Remove an item");
                Console.WriteLine("c.Show all items and their definitions");
                Console.WriteLine("d.Exit");
                Console.Write("Choose option between a and d: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":

                        //Asking user to enter item
                        Console.Write("Enter an item: ");
                        string item = Console.ReadLine();

                        if (items.ContainsKey(item))
                        {
                            Console.WriteLine("This item alread exists. Do you want to overwrite it?");
                            string answer = Console.ReadLine();
                            if (answer != "yes")

                             break;
                        }
                        Console.Write("Enter item definition: ");
                        string definition = Console.ReadLine();
                        items[item] = definition;
                        break;


                    case "b":
                        //Removing item
                        Console.Write("Enter a item to remove: ");
                        string itemToRemove = Console.ReadLine();

                        if (items.ContainsKey(itemToRemove))
                        {
                            items.Remove(itemToRemove);
                            Console.WriteLine("Item removed successfully!");

                        }
                        else
                        {
                            Console.WriteLine("Item not found.");
                        }
                            break;

                        case "c":

                        //Showing all items
                        Console.WriteLine("Items and their definitions: ");
                        if (items.Count == 0)
                        {
                            Console.WriteLine("Items not found");
                        }
                        else
                        {
                            foreach (var pair in items)
                            {
                                Console.WriteLine($"item: {pair.Key} defininion: {pair.Value}");
                            }
                        }
                            break;

                    case "d":


                        Console.WriteLine("Exiting the program.");
                        return;


                    default:
                        Console.WriteLine("Invalid option. Please try again");
                        break;
                }   


            }

            Console.ReadLine();
        }
    }
}
