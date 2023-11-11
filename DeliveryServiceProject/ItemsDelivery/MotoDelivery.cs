using DeliveryServiceProject.Interfaces;
using DeliveryServiceProject.TypeOfOrders;
namespace DeliveryServiceProject.ItemsDelivery;

internal class MotoDelivery : IDelivery
{
    string MotoName { get; }
    string Name { get; }
    int Time { get; }
    public MotoDelivery(string motoName, string name)
    {
        MotoName = motoName;
        Name = name;
        Time = 60;
    }
    public void DeliveryOrder(Order order)
    {
        Console.WriteLine($"Moto delivery on the {MotoName} with name {Name} begin delivery {order.Name} to {order.DeliveryAddress}! Delivery time is {Time} min.");
    }
    public int ExpectedDeliveryTime()
    {
        return Time;
    }
}
