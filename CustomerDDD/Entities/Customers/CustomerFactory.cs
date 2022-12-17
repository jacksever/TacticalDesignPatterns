namespace CustomerDDD.Entities.Customers;

public static class CustomerFactory
{
    public static Customer CreateCustomer(PayMethods payMethod, CardTypes? cardType)
    {
        var customer = new Customer(Guid.NewGuid());
        var user = new User("Alexander", "Moscow");
        customer.AddUser(user);
        customer.AddPayMethod(payMethod);
        customer.AddCardType(cardType);
        return customer;
    }
}