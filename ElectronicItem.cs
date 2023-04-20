namespace LagerUke5
{
    internal class ElectronicItem : InventoryItem , ISellable
    {
        public readonly string _description;

        public ElectronicItem(string name, int count, double price, string description) : base(name, count, price)
        {
            _description = description;
        }

        public string CalculatePrice(int number)
        {
            return $"{number * Price}";
        }
    }
}
