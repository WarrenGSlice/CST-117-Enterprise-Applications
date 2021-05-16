using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* * * * * * * * * * * * *
 * * Warren Peterson * * *
 * This is my Own Work * *
 * CST-117 5/15/2021 * * *
 * * * Milestone 5 * * * *
 * * * * * * * * * * * * */
namespace Milestone2
{
    // Inventory Manager Class that contains the methods to Add, Edit and Remove items from the Inventory
    public class InventoryManager
    {
        // Creates a List of Inventory Items Object that can be called on in the other classes.
        public List<InventoryItems> Inventory { get; set; } = new List<InventoryItems>();
        public static int DEFAULT_QUANTITY { get; } = 10; // Sets default item property quantity to value of 1
        public Inventory Ii { get; set; } // Inherits the Invetory class with the form objects

        // Add Item method for adding items to the Item List
        public InventoryItems AddItem(InventoryItems item)
        {
            if (ContainsItem(item))
            {
                InventoryItems foundItem = FindItem(item);
                foundItem.TotalQuantity += item.TotalQuantity;
                return foundItem;
            }
            else
            {
                Inventory.Add(item);
                return item;
            }
        }// end of method

        // Method to edit the Inventory Item.... Does not work
        public void EditItem(InventoryItems items)
        {
            List<string> list = new List<string>();
            Inventory.Add(items);
            for(int i=0; i<list.Count; i++)
            {
                if (list[i].Contains(Ii.TotalQtyOutput.Text))
                    list[i] = Ii.TotalQuantityInventoryTextBox.Text;
            }
        }// End of method

        // Unused
        public void EditItems(List<string[]> items)
        {
            foreach (string[] item in items)
            {
                InventoryItems changedItem = new InventoryItems(item);
                EditItem(changedItem);
            }
        }// End of method

        // Add Item method for adding items to the List Array and also creates a new Inventory object 
        // whenever a new item is added
        public void AddItems(List<string[]> items)
        {
            foreach (string[] item in items)
            {
                InventoryItems newItem = new InventoryItems(item);
                AddItem(newItem);
            }
        }// end of method

        // Method for searching by Name, single word
        public InventoryItems FindItem(string itemName)
        {
            return Inventory.Find(x => x.Equals(itemName.ToString()));
        }// end of method

        // Method for finding items
        public InventoryItems FindItem(InventoryItems item)
        {
            return Inventory.Find(x => x.Equals(item.ToString()));
        }// end of method

        // Method for searching by Media
        public List<InventoryItems> MediaSearch(string type)
        {
            List<InventoryItems> searchResults = new List<InventoryItems>();
            return Inventory.FindAll(x => x.Equates(type.ToString()));
        }// end of method

        // Method for searching by Genre
        public List<InventoryItems> GenreSearch(string type)
        {
            List<InventoryItems> searchResults = new List<InventoryItems>();
            return Inventory.FindAll(x => x.WillFind(type.ToString()));
        }// end of method

        // Method for Searching and finding Items
        public List<InventoryItems> FindItems(string itemName, string desc)
        {
            List<InventoryItems> searchResults = new List<InventoryItems>();
            return Inventory.FindAll(x => x.Equals(itemName.ToString(), desc.ToString()));
        }// end of method

        // Method for searching by ID
        public List<InventoryItems> IdSearch(int id)
        {
            List<InventoryItems> idResults = new List<InventoryItems>();
            return Inventory.FindAll(x => x.IDFind(id));
        }// end of method

        // Method for searching by Name, multi word
        public List<InventoryItems> FindItemsUnder(decimal price)
        {
            List<InventoryItems> searchResults = new List<InventoryItems>();
            return Inventory.FindAll(x => x.Price < price);
        }// end of method

        // Helper Method used for finding items contained in the item List
        public bool ContainsItem(InventoryItems item)
        {
            return Inventory.Contains(item);
        }// end of method

        //Method for Removing items
        public bool RemoveItem(InventoryItems item)
        {
            if (ContainsItem(item))
            {
                Inventory.Remove(item);
                return true;
            }
            return false;
        }// end of method

        // To String method that ensures newly added items are added in the correct format
        public override string ToString()
        {
            string value = ""; // Sets the variable value to type string and value to blank
            foreach (InventoryItems item in Inventory)
            {
                value += "[" + item.ToString() + "]\n\n";
            }
            return value;
        }// end of method

        // Method that takes each line from the CSV List and creates a new list array
        // object for holding them and then returns the results
        public List<string[]> GetCSVList()
        {
            List<string[]> lines = new List<string[]>(); // For the CSVList method to store text in an array
            foreach (InventoryItems item in Inventory)
            {
                lines.Add(item.ToArray());
            }
            return lines;
        }// end of method

        // Unused
        public void RestockItem(string item)
        {
            InventoryItems inventoryitems = FindItem(item);
            if (inventoryitems.OutOfStock() || inventoryitems.QuantityInStock < DEFAULT_QUANTITY)
            {
                inventoryitems.TotalQuantity = DEFAULT_QUANTITY + inventoryitems.QuantityCheckedOut;
                inventoryitems.QuantityInStock = inventoryitems.TotalQuantity - inventoryitems.QuantityCheckedOut;
            }
        }// end of method

        // Method that re-stocks the Inventory Items
        public void RestockItem(InventoryItems item)
        {
            InventoryItems inventoryItems = FindItem(item);
            if (inventoryItems.OutOfStock() || inventoryItems.QuantityInStock < DEFAULT_QUANTITY)
            {
                inventoryItems.TotalQuantity = DEFAULT_QUANTITY + inventoryItems.QuantityCheckedOut;
                inventoryItems.QuantityInStock = inventoryItems.TotalQuantity - inventoryItems.QuantityCheckedOut;
            }
        } // end of method
    }
}
