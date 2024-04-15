using System;

class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }
}

class Bag
{
    private Item[] items;
    private bool _isOpen;

    public Bag()
    {
        items = new Item[8];
        _isOpen = false;
    }

    public void Open()
    {
        _isOpen = true;
    }

    public void Close()
    {
        _isOpen = false;
    }

    public void AddItem(Item item)
    {
        if (!_isOpen)
        {
            Console.WriteLine("Bag is closed. Open the bag to add items.");
            return;
        }

        bool bagFull = true;
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                Console.WriteLine($"Item '{item.Name}' added to the bag.");
                bagFull = false;
                break;
            }
        }

        if (bagFull)
        {
            Console.WriteLine("Bag is full. Cannot add more items.");
        }
    }

    public Item RemoveItem(int index)
    {
        if (!_isOpen)
        {
            Console.WriteLine("Bag is closed. Open the bag to remove items.");
            return null;
        }

        if (index < 0 || index >= items.Length)
        {
            Console.WriteLine("Invalid index.");
            return null;
        }

        if (items[index] == null)
        {
            Console.WriteLine("No item found at the specified index.");
            return null;
        }

        Item removedItem = items[index];
        items[index] = null;
        Console.WriteLine($"Item '{removedItem.Name}' removed from the bag.");
        return removedItem;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Bag bag = new Bag();

        // Opening bag
        bag.Open();

        // Adding items
        bag.AddItem(new Item("Sword"));
        bag.AddItem(new Item("Shield"));
        bag.AddItem(new Item("Potion"));
        bag.AddItem(new Item("Key"));

        // Trying to add more items than capacity
        bag.AddItem(new Item("Gold"));

        // Closing bag
        bag.Close();

        // Trying to add item when bag is closed
        bag.AddItem(new Item("Gemstone"));

        // Removing an item
        bag.Open();
        Item removedItem = bag.RemoveItem(1);

        // Trying to remove item with invalid index
        bag.RemoveItem(10);
    }
}
