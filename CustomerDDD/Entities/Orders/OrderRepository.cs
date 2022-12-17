namespace CustomerDDD.Entities.Orders;

public class OrderRepository : IRepository<Order>
{
    private static readonly List<Order> OrderList = new()
    {
        OrderFactory.CreateOrder(new Address("Moscow", "Lenina", "456234")),
        OrderFactory.CreateOrder(new Address("Moscow", "Red Square", "000001"))
    };

    public IEnumerable<Order> GetAll()
    {
        return OrderList;
    }

    public Order? GetById(Guid id)
    {
        return OrderList.Find(order => order.Id == id);
    }

    public void Add(Order order)
    {
        OrderList.Add(order);
    }

    public void Update(Order order)
    {
        var findOrder = OrderList.Find(entity => entity.Id == order.Id);
        if (findOrder != null)
        {
            OrderList.Remove(findOrder);
            OrderList.Add(order);
        }
    }

    public void Remove(Order order)
    {
        var findOrder = OrderList.Find(entity => entity.Id == order.Id);
        if (findOrder != null)
        {
            OrderList.Remove(findOrder);
        }
    }
}