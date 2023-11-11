using DeliveryServiceProject.Interfaces;
using DeliveryServiceProject.TypeOfOrders;
namespace DeliveryServiceProject.ItemsDelivery;

internal class AutoDelivery : IDelivery
{
    string AutoName { get; }
    string Name { get; }
    int Time { get; }
    public AutoDelivery(string autoName, string name)
    {
        AutoName = autoName;
        Name = name;
        Time = 100;
    }
    public void DeliveryOrder(Order order)
    {
        Console.WriteLine($"AutoDelivery on the {AutoName} with name {Name} begin delivery {order.Name} to {order.DeliveryAddress}! Delivery time is {Time} min.");
    }
    public int ExpectedDeliveryTime()
    {
        return Time;
    }
}
