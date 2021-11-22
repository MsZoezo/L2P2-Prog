using System;
using System.Collections.Generic;
using System.Text;

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
}
