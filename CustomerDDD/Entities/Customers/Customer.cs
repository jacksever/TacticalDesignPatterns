namespace CustomerDDD.Entities.Customers;

public class Customer
{
    public Guid Id { get; }
    public User User { get; set; }

    public PayMethods PayMethod { get; set; }

    public CardTypes? CardType { get; set; }

    public Customer(Guid id)
    {
        Id = id;
    }

    public void AddUser(User user)
    {
        User = user;
    }

    public void AddPayMethod(PayMethods payMethod)
    {
        PayMethod = payMethod;
    }

    public void AddCardType(CardTypes? cardType)
    {
        if (PayMethod == PayMethods.CARD && cardType != null)
        {
            CardType = cardType;
        }
    }

    public override string ToString()
    {
        return "Id: " + Id + " User: " + User.Name + " PayMethod: " + PayMethod;
    }
}