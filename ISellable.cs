namespace LagerUke5
{
    internal interface ISellable
    {
        string Name { get; }
        string CalculatePrice(int number);
    }
}
