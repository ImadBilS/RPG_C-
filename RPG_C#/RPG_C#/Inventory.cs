using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_C_
{
    internal class Inventory
    {
        private List<Item> items;

        public Inventory()
        {
            items = new List<Item>();
        }

        // Add an item to the inventory
        public void AddItem(Item item)
        {
            // Check if the item already exists in the inventory
            var existingItem = items.Find(i => i.GetName() == item.GetName());
            if (existingItem != null)
            {
                // If it exists, increase the quantity
                existingItem.SetQuantity(existingItem.GetQuantity() + item.GetQuantity());
            }
            else
            {
                // If it doesn't exist, add it to the inventory
                items.Add(item);
            }
        }

        // Remove an item from the inventory
        public bool RemoveItem(string itemName, int quantity)
        {
            var item = items.Find(i => i.GetName() == itemName);
            if (item != null)
            {
                if (item.GetQuantity() >= quantity)
                {
                    item.SetQuantity(item.GetQuantity() - quantity);
                    // If quantity becomes zero, remove the item from the inventory
                    if (item.GetQuantity() == 0)
                    {
                        items.Remove(item);
                    }
                    return true;
                }
                else
                {
                    Console.WriteLine("Not enough quantity to remove.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Item not found in inventory.");
                return false;
            }
        }

        // List all items in the inventory
        public void ListItems()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
                return;
            }

            Console.WriteLine("Inventory Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item.GetName()} (Quantity: {item.GetQuantity()}) - {item.GetDescription()}");
            }
        }

    }
}
