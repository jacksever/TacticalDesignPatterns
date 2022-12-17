namespace CustomerDDD.Entities.Customers;

public class User
{
    public Guid Id = Guid.NewGuid();
    public string Name { get; }
    public string City { get; }

    public User(string name, string city)
    {
        Name = name;
        City = city;
    }
}