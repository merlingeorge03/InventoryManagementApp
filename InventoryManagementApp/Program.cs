using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    public class InventoryItem
    {
        // Properties
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        // Constructor
        public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
        {
            // TODO: Initialize the properties with the values passed to the constructor.
            ItemName = itemName;
            ItemId = itemId;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        // Methods

        // Update the price of the item
        public void UpdatePrice(double newPrice)
        {
            // TODO: Update the item's price with the new price.
            Price = newPrice;
        }

        // Restock the item
        public void RestockItem(int additionalQuantity)
        {
            // TODO: Increase the item's stock quantity by the additional quantity.
            QuantityInStock += additionalQuantity;
        }

        // Sell an item
        public void SellItem(int quantitySold)
        {
            // TODO: Decrease the item's stock quantity by the quantity sold.
            // Make sure the stock doesn't go negative.
            if (QuantityInStock >= quantitySold)
            {
                QuantityInStock -= quantitySold;
                Console.WriteLine($"\nItem Name: {ItemName} , Quantity sold: {quantitySold}");
            }
            else
            {
                Console.WriteLine($"\nItem Name: {ItemName}, Quantity in stock: {QuantityInStock} \nRequested quantity to be sold = {quantitySold} \n Quantity not in stock to sell");
            }
        }

        // Check if an item is in stock
        public bool IsInStock()
        {
            // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
            if (QuantityInStock > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Print item details
        public void PrintDetails()
        {
            // TODO: Print the details of the item (name, id, price, and stock quantity).
            Console.WriteLine($"Item Name: {ItemName} , Item ID: {ItemId} , Price: {Price} , Quantity in stock:{QuantityInStock}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of InventoryItem
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // TODO: Implement logic to interact with these objects.
            // Example tasks:
            // 1. Print details of all items.
            Console.WriteLine("\n------Initial Inventory------");
            item1.PrintDetails();
            item2.PrintDetails();

            // 2. Sell some items and then print the updated details.
            item1.SellItem(20); //Selling 5 Laptops
            item2.SellItem(2); // Selling 2 smartphones

            Console.WriteLine("\n------Inventory after selling------");
            item1.PrintDetails();
            item2.PrintDetails();

            // 3. Restock an item and print the updated details.
            item1.RestockItem(3);
            item2.RestockItem(4);

            Console.WriteLine("\n------Inventory after restocking------");
            item2.PrintDetails();

            // 4. Check if an item is in stock and print a message accordingly.

            Console.WriteLine("\n------Inventory stock check------");
            Console.WriteLine(item1.IsInStock() ? "Laptop is in stock" : "Laptop is out of stock");

            Console.ReadLine();
        }
    }
}
