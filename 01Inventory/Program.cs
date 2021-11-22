using System;
using System.Collections.Generic;

namespace _01Inventory
{


    class Inventory
    {
        private List<Item> _items = new List<Item>();
        
        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetItems()
        {
            return _items;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            inventory.AddItem(new Item("kaas"));
            inventory.AddItem(new Item("melk"));

            List<Item> items = inventory.GetItems();

            foreach(Item item in items)
            {
                Console.WriteLine(item.name);
            }
        }
    }
}
