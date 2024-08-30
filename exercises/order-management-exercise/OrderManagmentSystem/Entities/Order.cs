namespace OrderManagmentSystem.Entities;
using OrderManagmentSystem.Entities.Enums;
using System.Text;
using System.Globalization;

internal class Order
{
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }
    public Client Client { get; set; }
    public List<OrderItem> OrdersItemList {  get; set; } = new List<OrderItem>();
    public Order() { }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        Moment = moment;
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem item)
    {
        OrdersItemList.Add(item);
    }
    public void RemoveItem(OrderItem item)
    {
        OrdersItemList.Remove(item);
    }
    public double Total()
    {
        double sum = 0;
        foreach (OrderItem item in OrdersItemList)
        {
            sum += item.subTotal();
        }
        return sum;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Order moment {Moment.ToString("dd/MM/yyy HH:mm:ss")}");
        sb.AppendLine($"Order status: {Status}");
        sb.AppendLine($"Client: {Client}");
        sb.AppendLine($"Order items: ");
        foreach (OrderItem item in OrdersItemList)
        {
            sb.AppendLine(item.ToString());
        }
        sb.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");
        return sb.ToString();
    }
}
