namespace CustomerDDD.Entities.Orders;

public class Address
{
    public string City { get; }
    public string Street { get; }
    public string Zip { get; }

    public Address(string city, string street, string zip)
    {
        City = city;
        Street = street;
        Zip = zip;
    }
}