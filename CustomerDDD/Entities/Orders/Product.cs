namespace CustomerDDD.Entities.Orders;

public class Product
{
    public string Name { get; }
    public double Weight { get; }
    public DateTime ProductionDate { get; }

    public Product(string name, double weight)
    {
        Name = name;
        Weight = weight;
        ProductionDate = DateTime.Now;
    }
}