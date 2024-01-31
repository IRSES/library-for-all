using Library.Models;
using System.IO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Program
    {
        static void Main(string[] args)
        {
            int choice;

            LibraryTable table = new LibraryTable();

            do
            {
                Console.WriteLine("1: Print Table.");
                Console.WriteLine("2: Create Section.");
                Console.WriteLine("3: Delete Section.");
                Console.WriteLine("0: Exit.");

                Console.WriteLine("Choose option: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            table.PrintTable();
                            break;
                        case 2:
                            //Add films and games
                            Console.WriteLine("Enter id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter section name:");
                            string sectionName = Console.ReadLine();
                            Console.WriteLine("Enter author:");
                            string author = Console.ReadLine();
                            Console.WriteLine("Enter title:");
                            string title = Console.ReadLine();
                            Console.WriteLine("Enter year of publishing:");
                            int yearPublishing = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter description:");
                            string description = Console.ReadLine();

                            //Add films and games
                            Books newBook = new Books(id, author, title, yearPublishing, description);
                            table.AddItem(sectionName, newBook);

                            int mark;
                            Console.WriteLine("4: Marked.");
                            Console.WriteLine("5: Unmarked.");
                            if (int.TryParse(Console.ReadLine(),out mark))
                            {
                                if (mark == 4)
                                {
                                    Console.WriteLine("Marked.");
                                }
                                else if (mark == 5) 
                                {
                                    Console.WriteLine("Unmarked.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input. Please select an existing option.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please select an existing option.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter section name to remove:");
                            string sectionToRemove = Console.ReadLine();
                            table.RemoveItem(sectionToRemove);
                            break;
                        case 0:
                            Console.WriteLine("Thanks for your time!");
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please select an existing option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please select an existing option.");
                }

                Console.WriteLine();
            } while (choice != 0);

            Console.ReadKey();
        }
    }
}
