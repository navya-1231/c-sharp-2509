using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class Item
    {
        public string Name { get; set; }
        private int stock;
        private double price;

        public int Stock
        {
            get { return stock; }
            set
            {
                if (value <= 0) {
                    throw new ArgumentException("Stock cannot be negative.");                    
                }
                stock = value;

            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0) { 
                    throw new ArgumentException("Price cannot be negative.");
                }                   
                price = value;  
            }
        }
        public Item(string name, int stock, double price)
        {
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
    public class InventorySystem {

        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void RemoveItem(string name)
        {
            
            items.RemoveAll(i=>i.Name == name);
        }
        public void UpdateStock(string name, int newStock)
        {
            //items.Find(i => i.Name == name).Stock = newStock;
            Item itemToUpdate = items.Find(i => i.Name == name);
            if (itemToUpdate != null)
            {
                itemToUpdate.Stock = newStock;
            }
            else
            {
                Console.WriteLine($"Item {name} not found in the inventory.");
            }

        }
        public void UpdatePrice(string name, double newPrice)
        {
            //items.Find(i => i.Name == name).Price = newPrice;
            Item itemToUpdate = items.Find(i => i.Name == name);
            if (itemToUpdate != null)
            {
                itemToUpdate.Price = newPrice;
            }
            else
            {
                Console.WriteLine($"Item {name} not found in the inventory.");
            }

        }
        public void DisplayInventory()
        {
            Console.WriteLine("\nInventory Items:");
            foreach (Item item in items)
            {
                Console.WriteLine($"Item: {item.Name}, Stock: {item.Stock}, Price: {item.Price}  " );
            }
            Console.WriteLine();
        }

    }

}
