namespace OOPAdventure;

public interface IInventory
{
    int Total { get; }
    void Add(Item item);
    void Remove(Item item);
    Item? Find(string itemName);
    Item? Find(string itemName, bool remove);
    bool Contains(string itemName);
    Item? Take(string itemName);
    void Use(string itemName, string source);
    
    public string[] InventoryList { get; }
}