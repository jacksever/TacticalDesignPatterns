using CustomerDDD.Entities.Customers;
using CustomerDDD.Entities.Orders;

//------------------ Customers --------------------//

var customerRepository = new CustomerRepository();
var allCustomers = customerRepository.GetAll().ToList();
foreach (var customer in allCustomers)
{
    Console.WriteLine(customer.ToString());
}

customerRepository.Add(CustomerFactory.CreateCustomer(PayMethods.FACE, null));

var findCustomer = customerRepository.GetById(customerRepository.GetAll().Last().Id);
if (findCustomer != null)
{
    Console.WriteLine(findCustomer.ToString());
}

Console.WriteLine("--------------------------------------------------------");

//------------------ Orders --------------------//

var orderRepository = new OrderRepository();
var allOrders = orderRepository.GetAll().ToList();
foreach (var order in allOrders)
{
    Console.WriteLine(order.ToString());
}

var newOrder = OrderFactory.CreateOrder(new Address("Milan", "Tpile", "3527178"));
newOrder.AddProducts(new List<Product>
{
    new("Salt", 1000), new("Bread", 300)
});
newOrder.SetOrderStatus(OrderStatus.COMPLETED);

orderRepository.Add(newOrder);

var findOrder = orderRepository.GetById(newOrder.Id);
if (findOrder != null)
{
    Console.WriteLine(findOrder.ToString());
}