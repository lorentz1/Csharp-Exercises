using OrderManagmentSystem.Entities;
using OrderManagmentSystem.Entities.Enums;
Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Client c1 = new Client(name, email, birthDate);
Order order1 = new Order(DateTime.Now, status, c1);
Console.Write("How many items to this order?: ");
int quantity = int.Parse(Console.ReadLine());

for(int i = 1; i <= quantity; i++)
{
    Console.WriteLine($"Enter #{i} item data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine());
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product product = new Product(productName, productPrice);
    OrderItem item = new OrderItem(productQuantity, productPrice, product);
    order1.AddItem(item);
}

Console.WriteLine("ORDERM SUMMARY");
Console.WriteLine(order1);