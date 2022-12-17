namespace CustomerDDD.Entities.Orders;

public static class OrderFactory
{
    public static Order CreateOrder(Address address)
    {
        return new Order(Guid.NewGuid(), address);
    }
}