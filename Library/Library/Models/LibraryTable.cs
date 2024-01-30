using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LibraryTable
    {
        // Dictionary for storing data, where the key is a section, the value is a list of elements in the section
        private Dictionary<string, List<LibraryItem>> table;

        public LibraryTable()
        {
            table = new Dictionary<string, List<LibraryItem>>();
        }

        public void AddItem(string section, LibraryItem item)
        {
            if (table.ContainsKey(section))
            {
                // If the section already exists, add the element to the existing list
                table[section].Add(item);
            }
            else
            {
                // If there is no section, create a new list and add an element
                List<LibraryItem> itemList = new List<LibraryItem> { item };
                table.Add(section, itemList);
            }
        }

        public void RemoveItem(string section)
        {
            table.Remove(section);
        }

        public void PrintTable()
        {
            foreach (var kvp in table)
            {
                Console.WriteLine($"Section: {kvp.Key}");
                Console.WriteLine("Data: ");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"- {item}");
                }
                Console.WriteLine();
            }
        }
    }
}
