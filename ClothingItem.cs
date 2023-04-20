using System.Collections.Specialized;

namespace LagerUke5
{
    internal class ClothingItem : InventoryItem , ISellable
    {
        public readonly string _description;

        public ClothingItem(string name, int count, double price, string description) : base(name, count, price)
        {
            _description = description;
        }


        public string CalculatePrice(int number)
        {
            return $"{number*Price}";
        }
    }
}
