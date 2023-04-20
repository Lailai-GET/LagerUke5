namespace LagerUke5
{
    internal class InventoryItem
    {
        public string Name { get; }
        public int Count { get; }
        public double Price { get; }


        public InventoryItem(string name, int count, double price)
        {
            Name = name;
            Count = count;
            Price = price;
        }
    }
}
