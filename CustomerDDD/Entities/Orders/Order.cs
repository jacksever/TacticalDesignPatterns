namespace CustomerDDD.Entities.Orders;

public class Order
{
    public Guid Id { get; }
    public OrderStatus Status { get; set; }
    public Address Address { get; }

    private readonly List<Product> _products = new();
    public IEnumerable<Product> Products => _products.ToList();

    public Order(Guid id, Address address)
    {
        Id = id;
        Address = address;
    }

    public void AddProducts(IEnumerable<Product> products)
    {
        _products.AddRange(products);
    }

    public void SetOrderStatus(OrderStatus status)
    {
        Status = status;
    }

    public override string ToString()
    {
        return "Id: " + Id + " Product Count: " + Products.Count() + " Status: " + Status;
    }
}