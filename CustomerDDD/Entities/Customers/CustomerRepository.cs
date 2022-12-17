namespace CustomerDDD.Entities.Customers;

public class CustomerRepository : IRepository<Customer>
{
    private static readonly List<Customer> CustomerList = new()
    {
        CustomerFactory.CreateCustomer(PayMethods.CARD, CardTypes.DEBIT),
        CustomerFactory.CreateCustomer(PayMethods.MONEY, null)
    };

    public IEnumerable<Customer> GetAll()
    {
        return CustomerList;
    }

    public Customer? GetById(Guid id)
    {
        return CustomerList.Find(customer => customer.Id == id);
    }

    public void Add(Customer customer)
    {
        CustomerList.Add(customer);
    }

    public void Update(Customer customer)
    {
        var findCustomer = CustomerList.Find(entity => entity.Id == customer.Id);
        if (findCustomer != null)
        {
            CustomerList.Remove(findCustomer);
            CustomerList.Add(customer);
        }
    }

    public void Remove(Customer customer)
    {
        var findCustomer = CustomerList.Find(entity => entity.Id == customer.Id);
        if (findCustomer != null)
        {
            CustomerList.Remove(findCustomer);
        }
    }
}