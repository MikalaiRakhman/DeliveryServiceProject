using DeliveryServiceProject.Interfaces;
using DeliveryServiceProject.TypeOfOrders;
namespace DeliveryServiceProject.ItemsDelivery;

internal class DronDelivery : IDelivery
{
    string ID { get; }
    int Time { get; }
    public DronDelivery(string iD)
    {
        ID = iD;
        Time = 40;
    }
    public void DeliveryOrder(Order order)
    {
        Console.WriteLine($"Dron delivery {ID} begin delivery {order.Name} to {order.DeliveryAddress}! Delivery time is {Time} min. I'll be back!!!");
    }
    public int ExpectedDeliveryTime()
    {
        return Time;
    }
}
